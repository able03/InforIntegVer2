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
    public partial class ProductForm : Form
    {
        private DBHelper dbHelper;
        public ProductForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlImage.BackgroundImage = ProductStaticClass.getImage();
            lblDesc.Text = ProductStaticClass.getDescription();
            lblName.Text= ProductStaticClass.getName();
            lblPrice.Text = "Php" + ProductStaticClass.getPrice().ToString();


            if(ProductStaticClass.getQty() == 0)
            {
                btnConfirm.Enabled = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string date = dt.ToString();
            dbHelper = new DBHelper();
            if (dbHelper.addOrder("ORDERED", date, CustomerStaticModel.getId(), ProductStaticClass.getId()))
            {
                MessageBox.Show("Order success");
                dbHelper.updateProduct(ProductStaticClass.getId(), ProductStaticClass.getQty());
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Order failed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
