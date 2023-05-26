using Firebase.Auth;
using Firebase.Database;
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
    }
}
