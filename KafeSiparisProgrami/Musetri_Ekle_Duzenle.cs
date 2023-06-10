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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSiparisProgrami
{
    public partial class Musetri_Ekle_Duzenle : Form
    {
       private FirebaseClient istemci;
        private UserCredential kimlik;
       private string resim_url = "";
        private Config ayarlar;


        public Musetri_Ekle_Duzenle(FirebaseClient istemci, UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            ayarlar = new Config();
            this.istemci = istemci;
            this.kimlik = kullanici_kimligi;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void musterieklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri yeni_must = new Musteri();
                yeni_must.Numara = numaratxt.Text;
                yeni_must.Ad = adtxt.Text;
                yeni_must.Soyad = soyadtxt.Text;

                if (resim_url != "")
                {
                    FirebaseStorage depolama = new FirebaseStorage(ayarlar.FireStorageDomain,
                        new FirebaseStorageOptions
                        {
                            AuthTokenAsyncFactory = () => kimlik.User.GetIdTokenAsync(),
                            ThrowOnCancel = true,
                        });
                    FileStream stream = File.Open(resim_url, FileMode.Open);
                    FirebaseStorageTask gonder=depolama.Child("profil_resimleri").Child(yeni_must.Numara).PutAsync(stream);
                    gonder.Progress.ProgressChanged += (s, evnt) => musteripbr.Value = evnt.Percentage;
                }
                await istemci.Child("Müşteriler").Child(yeni_must.Numara).PutAsync(yeni_must);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Mesaj: " + exc.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                this.Close();
            }
        }

        private void resimsecbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            if (resimsec.ShowDialog() == DialogResult.OK)
            {
                Image resim = Image.FromFile(resimsec.FileName);
                resim_pb.Image = resim;
                resim_url = resimsec.FileName;
            }
        }
    }
}
