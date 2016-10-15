using System;
using System.Windows.Forms;

namespace WindowsFormsSamples.Simple
{
    public partial class Sample1 : Form
    {
        public Sample1()
        {
            InitializeComponent();
        }

        private void Lifecycle_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            AddItemsToListBox();
        }

        private void AddItemsToListBox()
        {
            lsbItems.Items.Add("Paris");
            lsbItems.Items.Add("Barcelona");
            lsbItems.Items.Add("London");
            lsbItems.Items.Add("Istanbul");
        }

        private void btnShowMe_Click(object sender, EventArgs e)
        {
            if (lsbItems.SelectedItem != null)
            {
                lblMessage.Text = lsbItems.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No item has been selected" , this.Text);
            }
        }

        private void Anchor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //var result = MessageBox.Show("Are you sure to close the ", Text, MessageBoxButtons.YesNo);
            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

            var dialog = new CloseDialog();
            if (dialog.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
