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
    public static class ProductStaticClass
    {
        private static int id;
        private static string name;
        private static string description;
        private static float price;
        private static Image image;
        private static string category;


       

        public static  void AddStaticProduct(int id1, string name1, string description1, float price1, Image image1, string category1)
        {

            id = id1;
            name = name1;
            description = description1;
            price = price1;
            image = image1;
            category = category1;

           
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

        public static double getPrice()
        {
            return price;
        }

        public static Image getImage()
        {
            return image;
        }

        public static string getCategory()
        {
            return category;
        }

    }


  
}
