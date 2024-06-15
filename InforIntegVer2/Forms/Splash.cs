using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InforIntegVer2.Forms
{
    public partial class Splash : Form
    {
        private DBHelper dBHelper;
        private static string TABLET = "TABLET", SYRUP = "SYRUP", VITAMIM = "VITAMIN", OINTMENT = "OINTMENT";
        public Splash()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
          
            
    

        }



        private void initValues()
        {
            DBHelper dBHelper = new DBHelper();
            
            if (dBHelper.getProductCount() == 0)
            {
                dBHelper.addProduct("Biogesic Paracetamol", "Lorem Ipsum Dolor sit amet. Dolor porum tio amte", "1300.0", Properties.Resources.biogesic, TABLET, 2);
                dBHelper.addProduct("Neozep Forte", "Lorem Ipsum Dolor sit amet. Dolor porum tio amte", "420.0", Properties.Resources.neozep, TABLET, 4);
                dBHelper.addProduct("Scotts Chewable", "Lorem Ipsum Dolor sit amet. Dolor porum tio amte", "225.0", Properties.Resources.scotts, VITAMIM, 6);
                dBHelper.addProduct("Cetirizine ALLERKID 60mL", "Lorem Ipsum Dolor sit amet. Dolor porum tio amte", "203.28", Properties.Resources.cetirizine, SYRUP, 8);
                dBHelper.addProduct("Ventolin Expectorant 100mL", "Lorem Ipsum Dolor sit amet. Dolor porum tio amte", "318.83", Properties.Resources.ventolin, SYRUP, 10);
                dBHelper.addProduct("Mupicin", "Lorem Ipsum Dolor sit amet. Dolor porum tio amte", "335.10", Properties.Resources.mupicin, OINTMENT, 12);
                dBHelper.addProduct("Goli Apple Cider Gummies 60 gummies", "Lorem Ipsum Dolor sit amet. Dolor porum tio amte", "397", Properties.Resources.gummies, VITAMIM, 14);
            }

            if(dBHelper.getAdminCount() == 0)
            {
                dBHelper.addAdmin("admin", "admin1234", 2);
            }

            dBHelper.close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 3;

            initValues();



            if (progressBar.Width >= 599)
            {
                timer1.Stop();
                Form form = new LoginForm();
                form.Show();
                this.Hide();
            }
        }
    }
}
