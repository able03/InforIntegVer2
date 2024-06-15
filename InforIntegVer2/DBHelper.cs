using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InforIntegVer2
{
    public class DBHelper
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private int rowsAffected;
        private string query;
        private SqlDataReader reader;

        public DBHelper()
        {
            con = new SqlConnection("Data Source=LAPTOP-JJ95G4IA\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True;Trust Server Certificate=True");
        }

        public bool addProduct(string name, float price, Image image, string category)
        {
            con.Open();


            query = $"INSERT INTO products(name, description, price, image, category) VALUES({name}, {price}, {ConvertImageToByteArray(image)}, category)";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }

            con.Close();
            if(rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public int getProductCount()
        {
            con.Open();
            query = $"SELECT COUNT(*) FROM products";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();

                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);

                       
                    }
                }
            }

            con.Close();

            return -1;
        }



        public List<TestUC> getProductList()
        {
            List<TestUC> testUCs = new List<TestUC>();

            con.Open();
            query = $"SELECT * FROM products";
            using (cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();

                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string description = reader.GetString(2);
                        float price = reader.GetFloat(3);
                        byte[] img = (byte[]) reader["image"];
                        string category = reader.GetString(5);

                        testUCs.Add(new TestUC(productId, name, description, price, ConvertByteArrayToImage(img), category));
                    }
                }
            }

            return testUCs;
        }





        public static byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat); 
                return memoryStream.ToArray();
            }
        }

        public static Image ConvertByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
            {
                throw new ArgumentException("Image data cannot be null or empty.", nameof(imageData));
            }

            using (MemoryStream memoryStream = new MemoryStream(imageData))
            {
                return Image.FromStream(memoryStream);
            }
        }


    }


}
