using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSamples.MDI
{
    public partial class MainForm : Form
    {

        public int Counter { get; set; } = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = new ChildForm();
            childForm.Text = "New Text Document " + (Counter++).ToString();
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi( MdiLayout.Cascade );
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm) this.ActiveMdiChild;
                childForm.documentTextBox.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Paste();
            }
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild?.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;

                var dialog = new SaveFileDialog();
                dialog.Filter = "Rich Text Files|*.rtf";
                dialog.AddExtension = true;
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    childForm.documentTextBox.SaveFile(dialog.FileName);
                    childForm.Text = dialog.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var childForm = new ChildForm();
                childForm.documentTextBox.LoadFile(dialog.FileName);
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
    }
}
