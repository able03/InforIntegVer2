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
    public partial class InventoryEditForm : Form
    {
        public InventoryEditForm()
        {
            InitializeComponent();

          setData();
        }

        public void setData()
        {
            tbxName.Text = ProductStaticClass.getName();
            tbxDesc.Text = ProductStaticClass.getDescription();
            tbxCat.Text = ProductStaticClass.getCategory();
            tbxPrice.Text = ProductStaticClass.getPrice().ToString();
            tbxQty.Text = ProductStaticClass.getQty().ToString();
        }


        private void InventoryEditForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBHelper dBHelper = new DBHelper();

            int id = ProductStaticClass.getId();
            string name = tbxName.Text;
            string desc = tbxDesc.Text;
            string price = tbxPrice.Text;
            string category = tbxCat.Text;
            int qty = Convert.ToInt32(tbxQty.Text);
            //Image image = btnImage.BackgroundImage;
            if(dBHelper.updateProduct(id, name, desc, price, category, qty))
            {
                MessageBox.Show("Update success");
                setData();
                this.Dispose();

            }    
            else
            {
                MessageBox.Show("Update success");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           DBHelper dbHelper = new DBHelper();

            if (dbHelper.deleteProduct(ProductStaticClass.getId()))
            {
                MessageBox.Show("Delete success");
            }
            else
            {
                MessageBox.Show("Delete failed");
            }

        }

        /*        private void btnImage_Click(object sender, EventArgs e)
                {
                    try
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                        openFileDialog.Multiselect = false;

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = openFileDialog.FileName;
                            SetButtonImage(filePath);
                        }
                    }
                    catch (Exception e1)
                    { MessageBox.Show("Error loading image: " + e1.Message); }
                }*/
        /*  private void SetButtonImage(string filePath)
          {
              try
              {
                  using (Image image = Image.FromFile(filePath))
                  {
                      btnImage.BackgroundImage = image;
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error loading image: " + ex.Message);
              }
          }*/



    }

}
