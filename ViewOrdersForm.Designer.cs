namespace CafeProject
{
    partial class ViewOrdersForm
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
            this.ViesOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViesOrdersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViesOrdersDataGrid
            // 
            this.ViesOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViesOrdersDataGrid.Location = new System.Drawing.Point(23, 69);
            this.ViesOrdersDataGrid.Name = "ViesOrdersDataGrid";
            this.ViesOrdersDataGrid.RowHeadersWidth = 51;
            this.ViesOrdersDataGrid.RowTemplate.Height = 24;
            this.ViesOrdersDataGrid.Size = new System.Drawing.Size(746, 351);
            this.ViesOrdersDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(311, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders List";
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViesOrdersDataGrid);
            this.Name = "ViewOrdersForm";
            this.Text = "ViewOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.ViesOrdersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViesOrdersDataGrid;
        private System.Windows.Forms.Label label1;
    }
}