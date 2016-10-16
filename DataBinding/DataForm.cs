using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private ObjectSource _source = new ObjectSource();
        private BindingSource _categoriesBindingSource = new BindingSource();
        private BindingSource _productsBindingSource = new BindingSource();

        private void DataForm_Load(object sender, EventArgs e)
        {
            _categoriesBindingSource.DataSource = _source.GetCategories();
            categoriesCombobox.ValueMember = "Id";
            categoriesCombobox.DisplayMember = "Name";
            categoriesCombobox.DataSource = _categoriesBindingSource;

            productNameTextBox.DataBindings.Add("Text", _productsBindingSource, "Name");
            productPriceTextBox.DataBindings.Add("Text", _productsBindingSource, "Price");

            productsListBox.DataSource = _productsBindingSource;
            productsListBox.DisplayMember = "Name";

            productsGrid.DataSource = _productsBindingSource;
        }

        private void categoriesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoryId = Convert.ToInt32(categoriesCombobox.SelectedValue);
            _productsBindingSource.DataSource = _source.GetProducts(categoryId);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var product = productsListBox.SelectedItem;
            _productsBindingSource.Remove(product);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _productsBindingSource.MovePrevious();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            _productsBindingSource.MoveNext();

        }
    }
}
