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
    public partial class OrdersUC : UserControl
    {
        private int id;
        private string status;
        private string date;
        private int cusId;
        private int proId;

        private DBHelper dbHelper = new DBHelper();
        
        public OrdersUC(int id, string status, string date, int cusId, int proId)
        {
            InitializeComponent();
            this.id = id;
            this.status = status;
            this.date = date;
            this.cusId = cusId;
            this.proId = proId;



            List<Object> objects = dbHelper.getProduct(proId);
            btnImage.BackgroundImage = (Image)objects[0];
            lblPrice.Text= (string) "Php"+objects[1];
            lblDate.Text = date;
            lblOrderName.Text = (string) objects[2];
        }


    }
}
