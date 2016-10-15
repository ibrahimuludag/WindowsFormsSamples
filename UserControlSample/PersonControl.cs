using System.Windows.Forms;

namespace WindowsFormsSamples.UserControlSample
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
