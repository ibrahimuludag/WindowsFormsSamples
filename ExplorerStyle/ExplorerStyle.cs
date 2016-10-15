using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplorerStyle
{
    public partial class ExplorerStyle : Form
    {
        public ExplorerStyle()
        {
            InitializeComponent();
        }

        private void ExplorerStyle_Load(object sender, EventArgs e)
        {
            var node=  new TreeNode("My Documents");
            node.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            treeView1.Nodes.Add(node);

            GetFolder(node);
        }

        private void GetFolder(TreeNode node)
        {
            var dir = new DirectoryInfo(node.Tag.ToString());

            foreach (var folder in dir.GetDirectories())
            {
                if (folder.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    return;
                }
                var childNode = new TreeNode(folder.Name);
                childNode.Tag = folder.FullName;
                node.Nodes.Add(childNode);

                GetFolder(childNode);
            }

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            listView1.Items.Clear();

            foreach (var file in Directory.GetFiles(selectedNode.Tag.ToString()))
            {
                var fi = new FileInfo(file);
                var item = new ListViewItem(fi.Name);
                item.Tag = file;

                listView1.Items.Add(item);
            }

        }
    }
}
