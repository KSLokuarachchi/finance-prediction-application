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
using W1534169_2019172.view.common;

namespace W1534169_2019172.view.user
{
    public partial class SignInView : Form
    {
        public User userDetails;
        public UserDetailsController userController = new UserDetailsController();

        public SignInView()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            userDetails = new User();
            userDetails.Username = txtUsername.Text;
            userDetails.Password = txtPassword.Text;

            string message = userController.SignInUser(userDetails);

            if(message.Equals("Success!")) {
                this.clearFields();
                this.Hide();
                new HomeView().Show();

            }
        }

        private void SignInView_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void clearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
