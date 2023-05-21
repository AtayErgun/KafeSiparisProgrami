using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KafeSiparisProgrami
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            string AuthDomain = config.DocumentElement.SelectSingleNode("/FireBase/AuthDomain").InnerText;
            string ApiKey = config.DocumentElement.SelectSingleNode("/FireBase/ApiKey").InnerText;
           
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(AuthDomain,ApiKey));
        }
    }
}
