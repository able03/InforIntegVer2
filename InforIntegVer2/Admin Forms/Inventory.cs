using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforIntegVer2.Admin_Forms
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            setData();
        }

        private void setData()
        {
            DBHelper dB = new DBHelper();
            List<InventoryUC> items = dB.getInventoryList();

            foreach (InventoryUC item in items)
            {
                mainPanel.Controls.Add(item);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form = new NewProductForm();
            form.Show();
            
        }
    }



}
