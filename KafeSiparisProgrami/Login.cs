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
        public Login(string AuthDomain,string ApiKey)
        {
            InitializeComponent();
            this.AuthDomain = AuthDomain;
            this.ApiKey = ApiKey;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisyapbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AuthDomain=" + AuthDomain + "\n ApiKey=" + ApiKey);
        }
        
    }
}
