﻿using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Musetri_Ekle_Duzenle mekle = new Musetri_Ekle_Duzenle(firebaseistemci,kullanici_kimligi);
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



            foreach (FirebaseObject < Musteri > Musteri in Müşteriler)
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

        private  void musteriler_dtgrvw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                secili_id = e.RowIndex;
                
            }
            /* int selected = e.RowIndex;
             // MessageBox.Show(musteriler_dtgrvw.Rows[selected].Cells[0].Value.ToString());

             Musetri_Ekle_Duzenle mekle = new Musetri_Ekle_Duzenle(firebaseistemci,kullanici_kimligi);
             mekle.Text = "Müşteri Bilgilerini Güncellle";
             mekle.numaratxt.Text= musteriler_dtgrvw.Rows[selected].Cells["Numara"].Value.ToString();
             mekle.adtxt.Text = musteriler_dtgrvw.Rows[selected].Cells["Ad"].Value.ToString();
             mekle.soyadtxt.Text = musteriler_dtgrvw.Rows[selected].Cells["Soyad"].Value.ToString();

             mekle.musterieklebtn.Text = "Güncelle";


             try
             {
                 string numara= musteriler_dtgrvw.Rows[selected].Cells["Numara"].Value.ToString();
                 string Müşteri = await firebaseistemci.Child("Müşteriler").Child(numara).Child("Resim").OrderByKey().OnceSingleAsync<string>();
             }
             catch(Exception exc)
             {

             }
             finally
             {

             }

             mekle.ShowDialog();
             Musteri_Listele();*/

        }
    //    if (secili_id != 1)
    //        {
    //            int selected = secili_id;
    //    // MessageBox.Show(musteriler_dtgrvw.Rows[selected].Cells[0].Value.ToString());

    //    Musetri_Ekle_Duzenle mekle = new Musetri_Ekle_Duzenle(firebaseistemci, kullanici_kimligi);
    //    mekle.Text = "Müşteri Bilgilerini Güncellle";
    //            mekle.numaratxt.Text = musteriler_dtgrvw.Rows[selected].Cells["Numara"].Value.ToString();
    //            mekle.adtxt.Text = musteriler_dtgrvw.Rows[selected].Cells["Ad"].Value.ToString();
    //            mekle.soyadtxt.Text = musteriler_dtgrvw.Rows[selected].Cells["Soyad"].Value.ToString();

    //            mekle.musterieklebtn.Text = "Güncelle";


                

    //            mekle.ShowDialog();
    //            Musteri_Listele();
    //}
    
    }
}
