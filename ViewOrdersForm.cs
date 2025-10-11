using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersBuisnessLayer;

namespace CafeProject
{
    public partial class ViewOrdersForm : Form
    {
        public ViewOrdersForm()
        {
            InitializeComponent();
            ViesOrdersDataGrid.DataSource = clsOrders.GetAllOrders();
        }

        
    }
}
