using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.view.user;

namespace W1534169_2019172
{
    public partial class Form1 : Form
    {

        public SignInView signInView;
        public SignUpView signUpView;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpView = new SignUpView();
            signUpView.Activate();
            signUpView.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            signInView = new SignInView();
            signInView.Activate();
            signInView.ShowDialog();
        }
    }
}
