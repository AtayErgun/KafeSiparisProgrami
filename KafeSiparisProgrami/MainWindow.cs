using Firebase.Auth;
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
        public MainWindow(UserCredential kullanici_kimligi)
        {
            InitializeComponent();
            this.kullanici_kimligi = kullanici_kimligi;
            this.Text = this.Text + " |Kullanici: " + kullanici_kimligi.User.Info.Email;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
