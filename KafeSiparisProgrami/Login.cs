using Firebase.Auth;
using Firebase.Auth.Providers;
using KafeSiparisProgrami.Controls;
using KafeSiparisProgrami.LoginCFolder;
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
    public partial class Login : Form
    {
        private string AuthDomain, ApiKey;
        private LoginC loginc;
        private CreateuserC createc;
        private int createubtn_Click;
        private FirebaseAuthClient client;
        public Login(string AuthDomain,string ApiKey)
        {
            InitializeComponent();
            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;
            createc = new CreateuserC();
            loginc = new LoginC();


            Kullanıcıgrişbtn_Click(this, EventArgs.Empty);

            this.loginc.Loginbtn.Click += Loginbtn_Click;
            this.createc.Createubtn.Click += Createubtn_Click;
            var config = new FirebaseAuthConfig
            {
                ApiKey = ApiKey,
                AuthDomain = AuthDomain,
                Providers = new FirebaseAuthProvider[] { new EmailProvider() },
                 };

            
             this.client = new FirebaseAuthClient(config);
        }

        private async void Loginbtn_Click(object sender, EventArgs e)
        {
            try {
                loginc.Loginbtn.Enabled = false;
                loginc.login_Pb.Visible = true;
                UserCredential kullanici_kimligi = await client.SignInWithEmailAndPasswordAsync(this.loginc.emailtxt.Text.Trim(), this.loginc.sifretxt.Text.Trim());
                this.Hide();
                MainWindow nesne = new MainWindow(kullanici_kimligi);  
                nesne.Show();
                 }

            catch(Exception exc)
            {
                MessageBox.Show("Hata:"+exc.Message);
                loginc.Loginbtn.Enabled = true;
                loginc.login_Pb.Visible = false;
            }
            finally
            {
                loginc.Loginbtn.Enabled = true;
                loginc.login_Pb.Visible = false;
            }
        }
        private async void Createubtn_Click(object sender, EventArgs e)
        {

            try
            {
               var kullanici_kimligi=await client.CreateUserWithEmailAndPasswordAsync(this.createc.emailtxt.Text.Trim(), this.createc.sifretxt.Text.Trim());
                MessageBox.Show(kullanici_kimligi.User.Uid);
            }

            catch (Exception exc)
            {
                MessageBox.Show("Hata:" + exc.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void yenikullanıcıbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(createc);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kullanıcıgrişbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(loginc);
        }

      
    }
}
