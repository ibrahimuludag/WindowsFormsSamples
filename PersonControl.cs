using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSamples
{
    public partial class PersonControl : UserControl
    {

        public Person Person
        {
            get
            {
                return new Person()
                {
                    Age = txtAge.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text
                };
            }
            set
            {
                txtAge.Text = value.Age;
                txtFirstName.Text = value.FirstName;
                txtLastName.Text = value.LastName;
            }
        }

        public PersonControl()
        {
            InitializeComponent();
        }
    }
}
