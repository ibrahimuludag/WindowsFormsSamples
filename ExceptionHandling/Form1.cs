using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetUrl_Click(object sender, EventArgs e)
        {
            GetUrl("http://abcccccc.co");
        }

        private void GetUrl(string url)
        {
            using (var client = new WebClient())
            {
                var content = client.DownloadData(url);
                using (var stream = new MemoryStream(content))
                {
                }
            }
        }

        private void btnGetUrlHandled_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var content = client.DownloadData("http://abcccccc.co");
                    using (var stream = new MemoryStream(content))
                    {
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
