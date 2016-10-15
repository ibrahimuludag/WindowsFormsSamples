using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDI
{
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        private static int _counter = 1;
        public static Form CreateForm()
        {
            var form = new DocForm();
            form.Text = "New Text Document " + (_counter++).ToString();
            SdiApplication.Instance.ApplicationContext.MainForm = form;
            form.Show();

            return form;
        }
    }
}
