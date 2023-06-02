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
    public partial class CreateuserUC : UserControl
    {
        internal object createbtn;

        public CreateuserUC()
        {
            InitializeComponent();
        }

        public object Createbtn { get; internal set; }

        private void Createbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
