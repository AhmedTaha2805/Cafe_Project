using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersBuisnessLayer;
using ItemsBuisnessLayer;
using OrdersBuisnessLayer;

namespace CafeProject
{
    public partial class LoginForm : Form
    {
        clsUsers CurrentUser = new clsUsers();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CurrentUser = clsUsers.Find(txtUserName.Text, txtPassword.Text);
            if (CurrentUser != null)
            {
                Form Form1 = new OrdersForm(CurrentUser);
                Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password are incorrect", "Login Failed", MessageBoxButtons.OK);
            }

        }

        private void lnkGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Form1 = new OrdersForm(null);
            Form1.Show();
            this.Hide();
        }
    }
}
