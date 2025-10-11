using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemsBuisnessLayer;
using OrdersBuisnessLayer;
using UsersBuisnessLayer;


namespace CafeProject
{
    public partial class OrdersForm : Form
    {

        clsUsers CurrentUser = new clsUsers();

        DataTable OrdersDataTable = new DataTable();

        int OrderPrice = 0;

        private void AddColumnsToOrdersDataTable()
        {
            OrdersDataTable.Columns.Add("ItemNum");
            OrdersDataTable.Columns.Add("ItemName");
            OrdersDataTable.Columns.Add("ItemCat");
            OrdersDataTable.Columns.Add("UnitPrice");
            OrdersDataTable.Columns.Add("TotalPrice");
        }

        public OrdersForm(clsUsers User)
        {
            InitializeComponent();
            ItemsdataGrid.DataSource = clsItems.GetAllItems();
            CurrentUser = User;
            if (User == null)
            {
                txtCurrentUser.Text = "Guest";
                btnItemsO.Visible = false;
                btnUsersO.Visible = false;
                btnViewOrders.Visible = false;
            }
            else
            {
                txtCurrentUser.Text = User.Name;
                
            }
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemsdataGrid.DataSource = clsItems.GetAllItemsOfCategory(cbCategory.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbCategory.Text = "Category";
            ItemsdataGrid.DataSource = clsItems.GetAllItems();

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(lbPrice.Text == "Order Amount")
            {
                MessageBox.Show("Order Not Completed", "Error", MessageBoxButtons.OK);
            }           
            int.TryParse(lbPrice.Text, out int price);
            clsOrders Order = new clsOrders(DateTime.Now,price,CurrentUser == null ? -1 : CurrentUser.ID);
            Order.AddOrder();
            if(MessageBox.Show("Order Placed Successfully", "Congratulations", MessageBoxButtons.OK) == DialogResult.OK)
            {               
                txtOrderNum.Text = clsOrders.GetNextOrderNum().ToString();                
            }
            

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtQuantity.Text,out int N))
            {
                MessageBox.Show("Enter a Quantity", "Error", MessageBoxButtons.OK);
                return;
            }
            if (ItemsdataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ItemsdataGrid.SelectedRows[0];
                string ItemNum = row.Cells["ItemNum"].Value.ToString();
                string ItemName = row.Cells["ItemName"].Value.ToString();
                string ItemCat = row.Cells["ItemCat"].Value.ToString();
                string UnitPrice = row.Cells["ItemPrice"].Value.ToString();
                string TotalPrice = (Convert.ToInt32(UnitPrice) * Convert.ToInt32(txtQuantity.Text)).ToString();
                OrdersDataTable.Rows.Add(ItemNum, ItemName, ItemCat, UnitPrice, TotalPrice);
                OrdersDataGrid.DataSource = OrdersDataTable;
                OrderPrice += Convert.ToInt32(TotalPrice);
                lbPrice.Text = OrderPrice.ToString();
                
            }
            else
            {
                MessageBox.Show("Please Select an item","Error",MessageBoxButtons.OK);
            }

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            AddColumnsToOrdersDataTable();
            lbDate.Text = DateTime.Now.ToString();
            txtOrderNum.Text = clsOrders.GetNextOrderNum().ToString();
            txtOrderNum.Enabled = false;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            Form form = new ViewOrdersForm();
            form.ShowDialog();
        }

        private void LnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void btnUsersO_Click(object sender, EventArgs e)
        {
            Form form = new UsersForm(CurrentUser);
            form.Show();
            this.Hide();
        }

        private void btnItemsO_Click(object sender, EventArgs e)
        {
            Form form = new ItemsForm(CurrentUser);
            form.Show();
            this.Hide();
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
