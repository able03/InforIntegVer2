﻿using InforIntegVer2.Forms;
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
        private string price;
        private Image image;
        private string category;
        private int qty;

        public TestUC(int id, string name, string description, string price, Image image, string category, int qty)
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

            string mPrice = price.ToString();
            lblPrice.Text = mPrice;
            lblQty.Text = qty.ToString();
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

        private void btnImg_Click(object sender, EventArgs e)
        {
            new ProductStaticClass(id, name, description, price, image, category, qty);
            Form form = new ProductForm();
            form.Show();
           
        }


    }
}
