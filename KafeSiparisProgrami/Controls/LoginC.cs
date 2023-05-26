using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSiparisProgrami.LoginCFolder
{
    public partial class LoginC : UserControl
    {
        public LoginC()
        {
            InitializeComponent();
        }

        public object Kullanıcıgrişbtn { get; internal set; }

        private void gostercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gostercheckBox.Checked)
                sifretxt.PasswordChar = '\0';
            else
                sifretxt.PasswordChar = '*';
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {



        }

        private void sifretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginC_Load(object sender, EventArgs e)
        {

        }
    }
}
