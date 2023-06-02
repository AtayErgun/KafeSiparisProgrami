using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSiparisProgrami.Controls
{
    public partial class LoginUC : UserControl
    {
        internal object loginbtn;
        internal object email;
        internal object password;
        private object sifretxt;

        public LoginUC()
        {
            InitializeComponent();
        }

        public object Loginbtn { get; internal set; }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gostercheckBox.Checked)
                passwordtxt.PasswordChar = '\0';
            else
                passwordtxt.PasswordChar = '*';
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
