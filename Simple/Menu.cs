using System;
using System.Windows.Forms;

namespace WindowsFormsSamples.Simple
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked New");
        }
    }
}
