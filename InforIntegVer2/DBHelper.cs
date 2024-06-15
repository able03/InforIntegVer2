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
            con = new SqlConnection("Data Source=LAPTOP-JJ95G4IA\\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True");
            open();
        }

        public void open()
        {
            con.Open();
        }

        public void close() 
        {
            con.Close();
        }

        public bool addProduct(string name, string description, string price, Image image, string category, int qty)
        {


            //query = $"INSERT INTO products(name, description, price, image, category) VALUES({name}, {description},{price}, {ConvertImageToByteArray(image)}, {category})";
            query = $"INSERT INTO products(name, description, price, image, category, qty) VALUES(@name, @description,@price, @image, @category, @qty)";
            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("name", name );
                cmd.Parameters.AddWithValue("description", description);
                cmd.Parameters.AddWithValue("price", price );
                cmd.Parameters.AddWithValue("image", ConvertImageToByteArray(image) );
                cmd.Parameters.AddWithValue("category", category);
                cmd.Parameters.AddWithValue("qty", qty);
                rowsAffected = cmd.ExecuteNonQuery();
            }


            if(rowsAffected > 0)
            {
                return true;
            }
            return false;
        }




        public bool addProduct1(string name, string description, string price,  string category, int qty)
        {


            //query = $"INSERT INTO products(name, description, price, image, category) VALUES({name}, {description},{price}, {ConvertImageToByteArray(image)}, {category})";
            query = $"INSERT INTO products(name, description, price, image, category, qty) VALUES(@name, @description, CONVERT(varbinary(max), @image), @price, @category, @qty)";
            using (cmd = new SqlCommand(query, con))
            {
                Image image1 = (Image)Properties.Resources.products;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@image", ConvertImageToByteArray(image1));
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@qty", qty);
                rowsAffected = cmd.ExecuteNonQuery();
            }


            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public int getProductCount()
        {
       
            query = "SELECT COUNT(*) FROM products";
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

            return -1;
        }

        public List<Object> getProduct(int id)
        {
            List<Object> objects = new List<Object>();

          
            query = $"SELECT image, price, name FROM products WHERE product_id = '{id}'";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected= cmd.ExecuteNonQuery();

                using (reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        byte[] bb = (byte[]) reader.GetValue(0);
                        string price = reader.GetString(1);
                        string name = reader.GetString(2);

                        objects.Add(ConvertByteArrayToImage(bb));
                        objects.Add(price);
                        objects.Add(name);
                    }
                }
            }

            return objects;
        }

        public bool updateProduct(int id, int qty)
        {
            
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }


            if(rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool updateProduct(int id, string name, string desc, string price, string category, int qty)
        {
          
            query = $"UPDATE products SET name = '{name}', description = '{desc}', price = '{price}', category = '{category}', qty = '{qty}' WHERE product_id = '{id}'";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();

                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(0);
                        string name1 = reader.GetString(1);
                        string description1 = reader.GetString(2);

                        string price1 = reader.GetString(3);
                        //float price = (float) price1;
                        byte[] img = (byte[])reader.GetValue(4);
                        string category1 = reader.GetString(5);
                        int qty1 = reader.GetInt32(6);

                        //ConvertByteArrayToImage(img)
                        //Properties.Resources.cetirizine
                     new ProductStaticClass(productId, name1, description1, price1, ConvertByteArrayToImage(img), category1, qty1);
                    }
                }
            }


            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }


        public bool deleteProduct(int id)
        {
            query = $"DELETE FROM products WHERE product_id = '{id}'";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }

            if(rowsAffected > 0)
            {
                return true;
            }
            return false;
        }






        public List<TestUC> getProductList()
        {
            List<TestUC> testUCs = new List<TestUC>();

            query = "SELECT * FROM products";
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
                       
                        string price1 = reader.GetString(3);
                        //float price = (float) price1;
                        byte[] img = (byte[]) reader.GetValue(4);
                        string category = reader.GetString(5);
                        int qty = reader.GetInt32(6);

                        //ConvertByteArrayToImage(img)
                        //Properties.Resources.cetirizine
                        testUCs.Add(new TestUC(productId, name, description, price1, ConvertByteArrayToImage(img), category, qty));
                    }
                }
            }
         

            return testUCs;
        }



        public List<InventoryUC> getInventoryList()
        {
            List<InventoryUC> inventoryUCs = new List<InventoryUC>();

            query = "SELECT * FROM products";
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

                        string price1 = reader.GetString(3);
                        //float price = (float) price1;
                        byte[] img = (byte[])reader.GetValue(4);
                        string category = reader.GetString(5);
                        int qty = reader.GetInt32(6);

                        //ConvertByteArrayToImage(img)
                        //Properties.Resources.cetirizine
                        inventoryUCs.Add(new InventoryUC(productId, name, description, price1, ConvertByteArrayToImage(img), category, qty));
                    }
                }
            }


            return inventoryUCs;
        }




        public bool addCustomer(string fname, string mname, string lname, string contact, string email, string address, string user_name, string password)
        {
            

            query = "INSERT INTO customers(first_name, middle_name, last_name, contact, email, address, user_name, password) " +
                "VALUES(@first_name, @middle_name, @last_name, @contact, @email, @address, @user_name, @password)";
            using (cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.AddWithValue("first_name", fname);
                cmd.Parameters.AddWithValue("middle_name", mname);
                cmd.Parameters.AddWithValue("last_name", lname);
                cmd.Parameters.AddWithValue("contact", contact);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("user_name", user_name);
                cmd.Parameters.AddWithValue("password", password);

                rowsAffected = cmd.ExecuteNonQuery();
            }

         
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;

        }

        public bool getCustomer(string username, string password)
        {
           
            query = $"SELECT * FROM customers WHERE user_name = '{username}' AND password = '{password}'";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();


                    using (reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            int id = reader.GetInt32(0); 
                            string fname = reader.GetString(1);
                            string mname = reader.GetString(2);
                            string lname = reader.GetString(3);
                            string contact = reader.GetString(4);
                            string email = reader.GetString(5);
                            string address = reader.GetString(6);
                            string uname = reader.GetString(7);
                            string pass = reader.GetString(8);

                            new CustomerStaticModel(id, fname, mname, lname, contact, email, address, uname, pass);

                            return true;
                        }
                    
                }
            }

        

            return false;
        }


        public bool updateCustomer(int id, string fname, string mname, string lname, string contact, string email, string address)
        {
          
            query = $"UPDATE customers SET first_name = '{fname}', middle_name = '{mname}', last_name = '{lname}', contact = '{contact}', email = '{email}', address = '{address}' WHERE customer_id = '{id}'";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }

        
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;

        }

        

        public bool addOrder(string status, string date, int customerId, int productId)
        {

          
            query = $"INSERT INTO orders(status, date, customer_id, product_id) VALUES('{status}', '{date}', '{customerId}', '{productId}')";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }

         

            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
            
        }

        public List<OrdersUC> getOrderList(int id)
        {
            List<OrdersUC> order = new List<OrdersUC>();

            query = $"SELECT * FROM orders WHERE customer_id = '{id}'";
            using (cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();

                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int orderId = reader.GetInt32(0);
                        string status = reader.GetString(1);
                        string date = reader.GetString(2);
                        int cusId = reader.GetInt32(3);
                        int proId = reader.GetInt32(4);


                        order.Add(new OrdersUC(orderId, status, date, cusId, proId));

                        //ConvertByteArrayToImage(img)
                        //Properties.Resources.cetirizine

                    }
                }
            }
       

            return order;
        }


        public bool addAdmin(string uname, string pass, int level)
        {
        

            query = $"INSERT INTO admins(user_name, password, lvl) VALUES('{uname}', '{pass}', '{level}')";
            using (cmd = new SqlCommand(query, con))
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }

         
            if(rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public int getAdminCount()
        {
         

            query = "SELECT COUNT(*) FROM admins";
            using (cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();

                using(reader = cmd.ExecuteReader()) 
                { 
                    if(reader.Read())

                    {
                    return reader.GetInt32(0); }}
            }
             

            return -1;
        }

        public bool getAdmin(string username, string password)
        {

           
            query = $"SELECT * FROM admins WHERE user_name = '{username}' AND password = '{password}'";
            using (cmd = new SqlCommand(query, con))
            {
                cmd.ExecuteNonQuery();

                using (reader = cmd.ExecuteReader())
                {
                    if(reader.Read()) 
                    {
                        int id = reader.GetInt32(0);
                        string uname = reader.GetString(1);
                        string pass = reader.GetString(2);
                        int level = (int) reader.GetInt32(3);

                        new AdminStaticClass(id, uname, pass, level);

                        return true;
                    }
                }
            }

   

               
            return false;
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
