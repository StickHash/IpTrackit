using IpTrackit.BLL;
using IpTrackit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpTrackit.GUI
{
    public partial class MainForm : Form
    {
        private IIpInfoManager manager = IpInfoManagerFact.GetInstance();
        public MainForm()
        {
            InitializeComponent();
            ipMaskedTextBox.ValidatingType= typeof(System.Net.IPAddress);
            ipMaskedTextBox.TypeValidationCompleted += new TypeValidationEventHandler(ipMaskedTextBox_TypeValidationCompleted);
        }

        private void ipMaskedTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Adresse IP incorrecte";
                toolTip1.Show("Désolé mais cette adresse IP n'est pas reconnue ", ipMaskedTextBox, ipMaskedTextBox.Location, 5000);
                e.Cancel = true;
            }
        }

        private void resultRichTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void ipLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var infos = manager.GetIpInfo(ipMaskedTextBox.Text);
            var infosText = "RESULTATS"
                          + "\nAdresse IP: " + infos.Query
                          + "\nPays: " + infos.Country
                          + "\nRegion: " + infos.RegionName
                          + "\nVille: " + infos.City
                          + "\nCode postal: " + infos.Zip
                          + "\nFournisseur d'accès: " + infos.Isp
                          + "\nSociété: " + infos.Org
                          + "\nNuméro AS: " + infos.As;
            resultRichTextBox.Text = infosText;
        }

        private void ipMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
