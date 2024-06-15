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
    public partial class SplashScreen : Form
    {
        private DBHelper dBHelper;
        private static string TABLET = "TABLET", SYRUP = "SYRUP", VITAMIM = "VITAMIN", OINTMENT = "OINTMENT";
        public SplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            initValues();
    

        }

        private void initValues()
        {
            dBHelper = new DBHelper();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 3;


            if (dBHelper.getProductCount() == 0)
            {
                dBHelper.addProduct("Biogesic Pracetaml", 1300f, Properties.Resources.biogesic, TABLET);
                dBHelper.addProduct("Neozep Forte", 420f, Properties.Resources.neozep, TABLET);
                dBHelper.addProduct("Scotts Chewable", 225f, Properties.Resources.scotts, VITAMIM);
                dBHelper.addProduct("Cetirizine ALLERKID 60mL", 203.28f, Properties.Resources.cetirizine, SYRUP);
                dBHelper.addProduct("Ventolin Expectorant 100mL", 318.83f, Properties.Resources.ventolin, SYRUP);
                dBHelper.addProduct("Mupicin", 335.10f, Properties.Resources.mupicin, OINTMENT);
                dBHelper.addProduct("Goli Apple Cider Gummies 60 gummies", 397f, Properties.Resources.gummies, VITAMIM);
            }

            if(progressBar.Width >= 599)
            {
                timer1.Stop();
                Form form = new Form2();
                form.Show();
                this.Hide();
            }
        }
    }
}
