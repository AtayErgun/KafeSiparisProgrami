using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSiparisProgrami
{
    public partial class MainWindow : Form
    {
        private UserCredential kullanici_kimligi;
        private FirebaseClient firebaseistemci;
        private Config ayarlar;
        FirebaseStorage firebase_depolama;
        private int secili_id = -1;
        private object firebase_istemci;

        public MainWindow(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            ayarlar = new Config();
            this.kullanici_kimligi = kullanici_kimligi;
            this.Text = this.Text + " |Kullanici: " + kullanici_kimligi.User.Info.Email;
            try
            {
                firebaseistemci = new FirebaseClient("https://kafesiparisprogrami-default-rtdb.firebaseio.com/",
                    new FirebaseOptions
                    {
                        AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                    });
                FirebaseStorage firebase_depolama = new FirebaseStorage(ayarlar.FireStorageDomain,
                       new FirebaseStorageOptions
                       {
                           AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync(),
                           ThrowOnCancel = true,
                       });
                Musteri_Listele();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Mesaj: " + exc.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Musetri_Ekle_Duzenle mekle = new Musetri_Ekle_Duzenle(firebaseistemci, kullanici_kimligi);
            mekle.ShowDialog();

            Musteri_Listele();

            //Musteri must1 = new Musteri();
            //must1.Ad = "Ergün";
            //must1.Soyad = "Atay";

            //Musteri must2 = new Musteri();
            //must2.Ad = "Deniz";
            //must2.Soyad = "Ata";

            //await firebaseistemci.Child("Müşteriler").Child("12345").PutAsync(must1);
            //await firebaseistemci.Child("Müşteriler").Child("54321").PutAsync(must2);

        }

        private async void Musteri_Listele()
        {
            status_lbl.Text = "Müşteri Listesi sunucudan çekiliyor";
            status_Pb.Visible = true;
            IReadOnlyCollection<FirebaseObject<Musteri>> Müşteriler = await firebaseistemci.Child("Müşteriler").OrderByKey().OnceAsync<Musteri>();

            DataTable Musteriler_table = new DataTable();
            Musteriler_table.Columns.Add("Numara", typeof(string));
            Musteriler_table.Columns.Add("Ad", typeof(string));
            Musteriler_table.Columns.Add("Soyad", typeof(string));



            foreach (FirebaseObject<Musteri> Musteri in Müşteriler)
            {
                Musteriler_table.Rows.Add(Musteri.Key, Musteri.Object.Ad, Musteri.Object.Soyad);
            }

            musteriler_dtgrvw.DataSource = Musteriler_table;
            status_lbl.Text = "";
            status_Pb.Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dtgrid_cms_Opening(object sender, CancelEventArgs e)
        {
            int x = dtgrid_cms.Bounds.Location.X - this.Location.X - musteriler_dtgrvw.Location.X - 8;
            int y = dtgrid_cms.Bounds.Location.Y - this.Location.Y - musteriler_dtgrvw.Location.Y - 32;
            secili_id = musteriler_dtgrvw.HitTest(x, y).RowIndex;

            musteriler_dtgrvw.ClearSelection();
            musteriler_dtgrvw.Rows[secili_id].Selected = true;
        }

        private async void düzenle_tsmenü_Click(object sender, EventArgs e)
        {
            status_Pb.Visible = true;
            musteriler_dtgrvw.Enabled = false;


            if (secili_id != 1)
            {
                int selected = secili_id;
                // MessageBox.Show(musteriler_dtgrvw.Rows[selected].Cells[0].Value.ToString());
                string numara = musteriler_dtgrvw.Rows[selected].Cells["Numara"].Value.ToString();
                string ad = musteriler_dtgrvw.Rows[selected].Cells["Ad"].Value.ToString();
                string soyad = musteriler_dtgrvw.Rows[selected].Cells["Soyad"].Value.ToString();

                Musetri_Ekle_Duzenle mekle = new Musetri_Ekle_Duzenle(firebaseistemci, kullanici_kimligi);
                mekle.Text = "Müşteri Bilgilerini Güncellle";
                mekle.numaratxt.Text = numara;
                mekle.adtxt.Text = ad;
                mekle.soyadtxt.Text = soyad;
                mekle.musterieklebtn.Text = "Güncelle";

                try
                {
                    string resim_url = await firebase_depolama.Child("profil_resimleri").Child(numara).Child("profil.png").GetDownloadUrlAsync();

                    WebClient istemci = new WebClient();
                    Stream raw_dosya = istemci.OpenRead(resim_url);
                    Bitmap resim = new Bitmap(raw_dosya);

                    mekle.resim_pb.Image = resim;

                    raw_dosya.Flush();
                    raw_dosya.Close();
                    istemci.Dispose();
                }
                catch (Exception exc)
                {

                }

                status_Pb.Visible = false;
                mekle.ShowDialog();
                Musteri_Listele();
            }
            musteriler_dtgrvw.Enabled = true;
            status_Pb.Visible = false;

        }

        private async void sil_tsmenü_Click(object sender, EventArgs e)
        {
            status_Pb.Visible = true;
            if (secili_id != 1)
            {
                int selected = secili_id;
               
                string numara = musteriler_dtgrvw.Rows[selected].Cells["Numara"].Value.ToString();
                string ad = musteriler_dtgrvw.Rows[selected].Cells["Ad"].Value.ToString();
                string soyad = musteriler_dtgrvw.Rows[selected].Cells["Soyad"].Value.ToString();

                string mesaj = String.Format("{0} numaralı {1} {2} isimli müşteriyi silmek üzeresiniz.Silme işlemini onaylıyor musunuz? ", numara, ad, soyad);

                if(MessageBox.Show(mesaj,"Dikkat!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {

                    try
                    {
                        string resim_url = await firebase_depolama.Child("profil_resimleri").Child(numara).Child("profil.png").GetDownloadUrlAsync();


                        await firebase_depolama.Child("profil_resimleri").Child(numara).Child("profil.png").DeleteAsync();
                    }
                    catch (Exception exc) { }

                    await firebaseistemci.Child("Müşteriler").Child(numara).DeleteAsync();

                    string mesaj2 = String.Format("{0} numaralı {1} {2} isimli müşteri sistemden silinmiştir.",numara,ad,soyad);

                    Musteri_Listele();
                    status_Pb.Visible = false;
                    MessageBox.Show(mesaj2, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            status_Pb.Visible = false;
        }
    } 
}
