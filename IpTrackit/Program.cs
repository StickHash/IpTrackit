using IpTrackit.BLL;
using IpTrackit.BO;
using IpTrackit.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpTrackit
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Program mainForm = new Program();
            mainForm.Start();

        }

        private readonly MainForm m_mainForm;
        private Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            m_mainForm = new MainForm();
        }

        public void Start()
        {
            Application.Run(m_mainForm);
        }
    }
}
