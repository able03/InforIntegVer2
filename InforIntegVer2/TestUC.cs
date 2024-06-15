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
    public partial class TestUC : UserControl
    {

        private int id;
        private string name;
        private string description;
        private float price;
        private Image image;
        private string category;

        public TestUC(int id, string name, string description, float price, Image image, string category)
        {
            InitializeComponent();

            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.image = image;
            this.category = category;

            lblName.Text = name;

            string mPrice = price.ToString();
            lblPrice.Text = mPrice;

            btnImg.BackgroundImage = image;


        }



        public void setData()
        {
            lblName.Text = name;

            string mPrice = price.ToString();
            lblPrice.Text = mPrice;
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

        public double getPrice()
        {
            return price;
        }

        public Image getImage()
        {
            return image;
        }

        public string getCategory()
        {
            return category;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {

            MessageBox.Show(name);
        }
    }
}
