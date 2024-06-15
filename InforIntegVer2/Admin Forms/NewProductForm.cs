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
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string desc = tbxDesc.Text;
            string price = tbxPrice.Text;
            string category = tbxCat.Text;
            int qty = Convert.ToInt32(tbxQty.Text);


           DBHelper dB = new DBHelper();

            if(dB.addProduct1(name, desc, price, category, qty))
            {
                MessageBox.Show("Add suucess");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Add failed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
