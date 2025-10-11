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

namespace CafeProject
{
    public partial class UsersForm : Form
    {
        clsUsers CurrentUser = new clsUsers();
        public UsersForm(clsUsers User)
        {
            InitializeComponent();
            CurrentUser = User;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UsersDataGrid.DataSource = clsUsers.GetAllUsers();
        }

        private void RefreshDataGrid()
        {
            UsersDataGrid.DataSource = clsUsers.GetAllUsers();
        }

        private bool ThereisNullTexts()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Enter a username", "Error", MessageBoxButtons.OK);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Enter a phone number", "Error", MessageBoxButtons.OK);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter a Password", "Error", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (ThereisNullTexts())
            {
                return;
            }
            clsUsers user = new clsUsers();
            user.Name = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.Phone = txtPhone.Text;
            if (user.Save())
            {
                MessageBox.Show("User Added Successfully", "Congratulations", MessageBoxButtons.OK);
            }
            RefreshDataGrid();

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (ThereisNullTexts())
            {
                return;
            }
            DataGridViewRow row = UsersDataGrid.SelectedRows[0];
            clsUsers user = clsUsers.Find(row.Cells["UserName"].Value.ToString(), row.Cells["UserPassword"].Value.ToString());
            user.Name = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.Phone = txtPhone.Text;
            if (user.Save())
            {
                MessageBox.Show("User Updated Successfully", "Congratulations", MessageBoxButtons.OK);
            }
            RefreshDataGrid();
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = UsersDataGrid.SelectedRows[0];
            clsUsers.DeleteUser(Convert.ToInt32(row.Cells["UserID"].Value));
            MessageBox.Show("User Deleted Successfully", "Congratulations", MessageBoxButtons.OK);
            RefreshDataGrid();
        }

        private void btnOrderU_Click(object sender, EventArgs e)
        {
            Form form = new OrdersForm(CurrentUser);
            form.Show();
            this.Hide();
        }

        private void btnItemsU_Click(object sender, EventArgs e)
        {
            Form form = new ItemsForm(CurrentUser);
            form.Show();
            this.Hide();
        }

        private void LnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
