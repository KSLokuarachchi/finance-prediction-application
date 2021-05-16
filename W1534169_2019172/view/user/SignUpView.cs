using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.controller.user;
using W1534169_2019172.model.user;

namespace W1534169_2019172.view.user
{
    public partial class SignUpView : Form
    {

        public User userDetails;
        public UserDetailsController userController = new UserDetailsController();


        public SignUpView()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            userDetails = new User();
            userDetails.FullName = txtName.Text;
            userDetails.Email = txtEmail.Text;
            userDetails.PhoneNumber = txtPhoneNo.Text;
            userDetails.Username = txtUsername.Text;
            userDetails.Password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string message = userController.SignUpUser(userDetails, confirmPassword);

            MessageBox.Show(message);

            if (message.Equals("Successfully Registered!"))
            {
                this.Hide();
                new SignInView().Show();
            }
            else
            {
                this.clearFields(message);
            }
            
        }

        private void SignUpView_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = new User();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void clearFields(string message) {

            if(message.Equals("Passwords didn't match. Please confirm the password"))
            {
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhoneNo.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
