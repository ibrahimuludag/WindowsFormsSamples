using System;
using System.Windows.Forms;

namespace WindowsFormsSamples.UserControlSample
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            personControl1.Person =  new Person() {Age = "45", FirstName = "Ahmet", LastName = "Yolcu"};
        }
    }
}
