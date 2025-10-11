namespace CafeProject
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.LnkLogOut = new System.Windows.Forms.LinkLabel();
            this.ItemsdataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtCurrentUser = new System.Windows.Forms.TextBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnItemsO = new System.Windows.Forms.Button();
            this.btnUsersO = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(784, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Window;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "drinks",
            "deserts"});
            this.cbCategory.Location = new System.Drawing.Point(225, 59);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(142, 28);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.Text = "Category";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNum.Location = new System.Drawing.Point(225, 120);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(142, 27);
            this.txtOrderNum.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepPink;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Location = new System.Drawing.Point(402, 59);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LnkLogOut
            // 
            this.LnkLogOut.AutoSize = true;
            this.LnkLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLogOut.Location = new System.Drawing.Point(12, 546);
            this.LnkLogOut.Name = "LnkLogOut";
            this.LnkLogOut.Size = new System.Drawing.Size(69, 20);
            this.LnkLogOut.TabIndex = 4;
            this.LnkLogOut.TabStop = true;
            this.LnkLogOut.Text = "Log Out";
            this.LnkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLogOut_LinkClicked);
            // 
            // ItemsdataGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ItemsdataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsdataGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsdataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsdataGrid.EnableHeadersVisualStyles = false;
            this.ItemsdataGrid.Location = new System.Drawing.Point(581, 45);
            this.ItemsdataGrid.MultiSelect = false;
            this.ItemsdataGrid.Name = "ItemsdataGrid";
            this.ItemsdataGrid.RowHeadersWidth = 51;
            this.ItemsdataGrid.RowTemplate.Height = 24;
            this.ItemsdataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsdataGrid.Size = new System.Drawing.Size(632, 171);
            this.ItemsdataGrid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepPink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(798, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your Order";
            // 
            // lbb
            // 
            this.lbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb.Location = new System.Drawing.Point(784, 535);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(45, 23);
            this.lbb.TabIndex = 8;
            this.lbb.Text = "EG";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.DeepPink;
            this.lbDate.Location = new System.Drawing.Point(1193, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(132, 29);
            this.lbDate.TabIndex = 9;
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Enabled = false;
            this.txtCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentUser.Location = new System.Drawing.Point(225, 176);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(142, 27);
            this.txtCurrentUser.TabIndex = 10;
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddCart.Location = new System.Drawing.Point(740, 276);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(142, 34);
            this.btnAddCart.TabIndex = 11;
            this.btnAddCart.Text = "Add To Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(740, 237);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(142, 27);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.Text = "Quantity";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.DeepPink;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPlaceOrder.Location = new System.Drawing.Point(600, 530);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(142, 32);
            this.btnPlaceOrder.TabIndex = 13;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.DeepPink;
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnViewOrders.Location = new System.Drawing.Point(1183, 530);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(142, 34);
            this.btnViewOrders.TabIndex = 14;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // OrdersDataGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.OrdersDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrdersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDataGrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGrid.EnableHeadersVisualStyles = false;
            this.OrdersDataGrid.Location = new System.Drawing.Point(600, 348);
            this.OrdersDataGrid.MultiSelect = false;
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.RowHeadersWidth = 51;
            this.OrdersDataGrid.RowTemplate.Height = 24;
            this.OrdersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGrid.Size = new System.Drawing.Size(574, 161);
            this.OrdersDataGrid.TabIndex = 15;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(823, 535);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(167, 23);
            this.lbPrice.TabIndex = 16;
            this.lbPrice.Text = "Order Amount";
            // 
            // btnItemsO
            // 
            this.btnItemsO.BackColor = System.Drawing.Color.DeepPink;
            this.btnItemsO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsO.ForeColor = System.Drawing.SystemColors.Window;
            this.btnItemsO.Location = new System.Drawing.Point(12, 76);
            this.btnItemsO.Name = "btnItemsO";
            this.btnItemsO.Size = new System.Drawing.Size(108, 31);
            this.btnItemsO.TabIndex = 17;
            this.btnItemsO.Text = "Items";
            this.btnItemsO.UseVisualStyleBackColor = false;
            this.btnItemsO.Click += new System.EventHandler(this.btnItemsO_Click);
            // 
            // btnUsersO
            // 
            this.btnUsersO.BackColor = System.Drawing.Color.DeepPink;
            this.btnUsersO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersO.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUsersO.Location = new System.Drawing.Point(12, 12);
            this.btnUsersO.Name = "btnUsersO";
            this.btnUsersO.Size = new System.Drawing.Size(108, 31);
            this.btnUsersO.TabIndex = 18;
            this.btnUsersO.Text = "Users";
            this.btnUsersO.UseVisualStyleBackColor = false;
            this.btnUsersO.Click += new System.EventHandler(this.btnUsersO_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Order Num";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1337, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUsersO);
            this.Controls.Add(this.btnItemsO);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.OrdersDataGrid);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.txtCurrentUser);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemsdataGrid);
            this.Controls.Add(this.LnkLogOut);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.LinkLabel LnkLogOut;
        private System.Windows.Forms.DataGridView ItemsdataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtCurrentUser;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.DataGridView OrdersDataGrid;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnItemsO;
        private System.Windows.Forms.Button btnUsersO;
        private System.Windows.Forms.Label label3;
    }
}