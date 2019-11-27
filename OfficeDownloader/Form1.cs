using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            const string commandText = "/K setup.exe /download download64.xml";
            Process.Start("CMD.exe", commandText);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            const string commandText = "/K setup.exe /configure config64.xml";
            Process.Start("CMD.exe", commandText);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Text to be displayed in the MessageBox
            var helpText = "HELP BOX:\n" +
                           "==============================================\n\n" +
                           "Click on the 'Download' button to get started and retrieve the latest files." +
                           "The files will begin downloading in the background after the command window displays." +
                           "It will be a blank window and there is no active logging due to limitations of the tool." +
                           "Once the command finishes, it will show an empty command shell waiting for input. After " +
                           "this you can close the command window and click on 'Install' \n\n" +
                           "The install process is automated. Once completed you can close all the windows.\n\n" +
                           "Regularly update the downloaded files for your convenience.\n\n" +
                           "Written by Schalk Conradie\n" +
                           "https://github.com/Schalkuz";

            MessageBox.Show(helpText);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
