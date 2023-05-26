using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
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
        public MainWindow(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            this.kullanici_kimligi = kullanici_kimligi;
            this.Text = this.Text + " |Kullanici: " + kullanici_kimligi.User.Info.Email;
            try
            { 
            firebaseistemci = new FirebaseClient("https://kafesiparisprogrami-default-rtdb.firebaseio.com/",
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => kullanici_kimligi.User.GetIdTokenAsync()
                });
                MessageBox.Show("Firebase Realtime Database için istemci oluşturuldu.." , "Başarılı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            Musteri must1 = new Musteri();
            must1.Ad = "Ergün";
            must1.Soyad = "Atay";

            Musteri must2 = new Musteri();
            must2.Ad = "Deniz";
            must2.Soyad = "Ata";

            await firebaseistemci.Child("Müşteriler").Child("12345").PutAsync(must1);
            await firebaseistemci.Child("Müşteriler").Child("54321").PutAsync(must2);

        }
    }
}
