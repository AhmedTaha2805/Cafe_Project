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

namespace CafeProject
{
    public partial class ItemsForm : Form
    {
        clsUsers CurrentUser = new clsUsers();
        public ItemsForm(clsUsers currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private bool ThereisNullTexts()
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Enter Item Name", "Error", MessageBoxButtons.OK);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(txtItemPrice.Text))
            {
                MessageBox.Show("Enter Item Price", "Error", MessageBoxButtons.OK);
                return true;
            }
            else if (cbCategory.Text != "drinks" || cbCategory.Text != "deserts")
            {
                MessageBox.Show("Choose a category", "Error", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            ItemsDataGrid.DataSource = clsItems.GetAllItems();
        }

        private void RefreshDataGrid()
        {
            ItemsDataGrid.DataSource = clsItems.GetAllItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ThereisNullTexts())
            {
                return;
            }
            clsItems Item = new clsItems();
            Item.ItemName = txtItemName.Text;
            Item.ItemCat = cbCategory.Text;
            Item.ItemPrice = Convert.ToInt32(txtItemPrice.Text);
            if (Item.Save())
            {
                MessageBox.Show("Item Added Successfully", "Congratulations", MessageBoxButtons.OK);
            }
            RefreshDataGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ThereisNullTexts())
            {
                return;
            }

            if (ItemsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ItemsDataGrid.SelectedRows[0];

                clsItems Item = clsItems.Find(Convert.ToInt32(row.Cells["ItemNum"].Value.ToString()));
                Item.ItemName = txtItemName.Text;
                Item.ItemCat = cbCategory.Text;
                Item.ItemPrice = Convert.ToInt32(txtItemPrice.Text);

                if (Item.Save())
                {
                    MessageBox.Show("Item Updated Successfully", "Congratulations", MessageBoxButtons.OK);
                }
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please Choose an item", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ItemsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ItemsDataGrid.SelectedRows[0];
                clsItems.DeleteItem(Convert.ToInt32(row.Cells["ItemNum"].Value.ToString()));
                MessageBox.Show("Item Deleted Successfully", "Congratulations", MessageBoxButtons.OK);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please Choose an item", "Error", MessageBoxButtons.OK);
            }
            RefreshDataGrid();
            
        }

        private void btnOrderI_Click(object sender, EventArgs e)
        {
            Form form = new OrdersForm(CurrentUser);
            form.Show();
            this.Hide();
        }

        private void btnUsersI_Click(object sender, EventArgs e)
        {
            Form form = new UsersForm(CurrentUser);
            form.Show();
            this.Hide();
        }

        private void LnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void ItemsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
