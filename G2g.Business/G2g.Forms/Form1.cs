using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using G2g.Business.Configuration;
using G2g.Business;
using G2g.Business.Util;

namespace G2g.Forms
{
    public partial class Form1 : Form
    {

        private string _euFile;
        private string _usFile;
        private EmailHelper _emailHelper;

        public Form1()
        {
            InitializeComponent();
            _emailHelper = new EmailHelper();
        }

        private void btnEuExcel_Click(object sender, EventArgs e)
        {
            sfdEuExcel.Filter = FileFilter();
            DialogResult result = sfdEuExcel.ShowDialog();
            if(result == DialogResult.OK)
            {
                _euFile = sfdEuExcel.FileName;
            }
        }

        private void btnUsExcel_Click(object sender, EventArgs e)
        {
            sfdUsExcel.Filter = FileFilter();
            DialogResult result = sfdUsExcel.ShowDialog();
            if (result == DialogResult.OK)
            {
                _usFile = sfdUsExcel.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            float priceMargine = float.Parse(tbxPriceMargine.Text);
            btnStart.Enabled = false;
            //Proces eu servers
            WowManager manager = new WowManager();
            var config = ConfigurationManager.GetSection("domainEu") as ServersConfigSection;
            //manager.ProcessServers(config.Servers, _euFile, priceMargine);
            _emailHelper.SendEmail("Finished processing EU servers, check if file is updated!", _euFile);


            btnStart.Enabled = true;

            //TODO: process us servers
        }

        private string FileFilter()
        {
            return "Excel File (*.xslx)|*.xlsx";
        }


    }
}
