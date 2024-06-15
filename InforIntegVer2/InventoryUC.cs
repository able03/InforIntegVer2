using InforIntegVer2.Admin_Forms;
using InforIntegVer2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforIntegVer2
{
    public partial class InventoryUC : UserControl
    {
        private int id;
        private string name;
        private string description;
        private string price;
        private Image image;
        private string category;
        private int qty;

        public InventoryUC(int id, string name, string description, string price, Image image, string category, int qty)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.image = image;
            this.category = category;
            this.qty = qty;


            lblName.Text = name;
            lblQty.Text = qty.ToString();
            string mPrice = price.ToString();
            lblPrice.Text = mPrice;
            lblDesc.Text = description;
            lblQty.Text = qty.ToString();
            btnInvImg.BackgroundImage = image;
        }


        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getDescription()
        {

            return description;
        }

        public float getPrice()
        {
            float convertedPrice = float.Parse(price);
            return convertedPrice;
        }

        public Image getImage()
        {
            return image;
        }

        public string getCategory()
        {
            return category;
        }
        public int getQty()
        {
            return qty;
        }


        private void InventoryUC_Load(object sender, EventArgs e)
        {

        }

        private void btnInvImg_Click(object sender, EventArgs e)
        {
            new ProductStaticClass(id, name, description, price, image, category, qty);
            Form form = new InventoryEditForm();
            form.Show();
        }
    }
}
