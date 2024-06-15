using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforIntegVer2.Forms
{
    public partial class OrdersForm : Form
    {
        private DBHelper dBHelper;
        public OrdersForm()
        {
            InitializeComponent();
            setData();
        }


        private void setData()
        {

            dBHelper = new DBHelper();
            List<OrdersUC> items = dBHelper.getOrderList(CustomerStaticModel.getId());

            foreach (OrdersUC item in items)
            {
                orderPanel.Controls.Add(item);
            }


        }
    }

    
}
