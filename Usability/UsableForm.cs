using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usability.Properties;

namespace Usability
{
    public partial class UsableForm : Form
    {
        public UsableForm()
        {
            InitializeComponent();
        }

        private void UsableForm_Load(object sender, EventArgs e)
        {
            if (!SystemInformation.HighContrast)
            {
                this.BackColor = Color.White;
            }
            ttName.SetToolTip(txtName , "Enter Your Name");
            if (Settings.Default.FirstRun)
            {
                MessageBox.Show("This is first run. Help text here");
                Settings.Default.FirstRun = false;
                Settings.Default.Save();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Space | Keys.Control))
            {
                btnSave.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                errorTxtName.SetError(txtName, TextResources.NameNotEmpty);
            }
            else
            {
                MessageBox.Show(TextResources.Saved);
            }
        }
    }
}
