using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InforIntegVer2
{
    public class ProductStaticClass
    {
        private static int id;
        private static string name;
        private static string description;
        private static string price;
        private static Image image;
        private static string category;
        private static int qty;


       

        public  ProductStaticClass(int id1, string name1, string description1, string price1, Image image1, string category1, int qty1)
        {

            id = id1;
            name = name1;
            description = description1;
            price = price1;
            image = image1;
            category = category1;
            qty = qty1;
           
        }



        public static int getId()
        {
            return id;
        }

        public static string getName()
        {
            return name;
        }

        public static string getDescription()
        {

            return description;
        }

        public static float getPrice()
        {
            return float.Parse(price);
        }

        public static Image getImage()
        {
            return image;
        }

        public static string getCategory()
        {
            return category;
        }

        public static int getQty() { return qty; }

    }


  
}
