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
    public partial class CreateuserC : UserControl
    {
        internal readonly object yenikullanıcıbtn;

        public CreateuserC()
        {
            InitializeComponent();
        }

        private void createubtn_Click(object sender, EventArgs e)
        {

        }

        private void gostercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gostercheckBox.Checked)
                sifretxt.PasswordChar = '\0';
            else
                sifretxt.PasswordChar = '*';
        }

        private void CreateuserC_Load(object sender, EventArgs e)
        {

        }
    }
}
