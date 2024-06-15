using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforIntegVer2
{
    public partial class Items : UserControl
    {

        private int id;
        private string name;
        private string description;
        private float price;
        private Image image;
        private string category;
        public Items()
        {
            InitializeComponent();
        }


        public Items(int id, string name, string description, float price, Image image, string category)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.image = image;
            this.category = category;
        }

        public void setData(Image image, string name)
        {
            lblName.Text = name;
            imgPanel.BackgroundImage = image;
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

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
