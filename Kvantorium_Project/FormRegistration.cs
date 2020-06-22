using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvantorium_Project
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Name = textBoxFirstName.Text;
            reg.Login = textBoxLogin.Text;
            reg.Password = textBoxLogin.Text;
            Program.KPDB.Registration.Add(reg);
            Program.KPDB.SaveChanges();
        }
    }
}
