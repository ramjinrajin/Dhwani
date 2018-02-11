using Dhwani._2.Application.Models;
using Dhwani._2.Application.UserSerice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dhwani
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserServiceLayer ObjService = new UserServiceLayer();
            User _user = new User
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                MobileNO = Convert.ToInt64(txtMobileNo.Text),
                Email = txtEmail.Text,
                DateOfBirth = DateTime.Now,//Convert.ToDateTime(txtDateofBirth.Text),
                Address = txtAddress.Text,
                Pincode = Convert.ToInt32(txtpincode.Text)


            };

            string Reponse = ObjService.UserService_GetResponse(_user);

            MessageBox.Show(Reponse);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttenregister_Click(object sender, EventArgs e)
        {

        }


    }
}
