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
    public partial class ProfileForm : Form
    {
        private DBHelper dBHelper;
        public ProfileForm()
        {
            InitializeComponent();
          
            setData();
        }

        private void setData()
        {
            tbxFname.Text = CustomerStaticModel.getfname();
            tbxMname.Text = CustomerStaticModel.getmname();
            tbxLname.Text = CustomerStaticModel.getlname();
            tbxContact.Text = CustomerStaticModel.getcontact();
            tbxEmail.Text = CustomerStaticModel.getemail();
            tbxAddress.Text = CustomerStaticModel.getaddress();

            string mname = CustomerStaticModel.getmname();
            char mname1 = mname[0];
            lblProfileName.Text = CustomerStaticModel.getfname() + " " + mname1 + ". " + CustomerStaticModel.getlname();

        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            dBHelper = new DBHelper();

            int id = CustomerStaticModel.getId();
            string fname = tbxFname.Text;
            string mname = tbxMname.Text;
            string lname = tbxLname.Text;
            string contact = tbxContact.Text;
            string email = tbxEmail.Text;
            string address = tbxAddress.Text;

            if (dBHelper.updateCustomer(id, fname, mname, lname, contact, email, address))
            {
                dBHelper.getCustomer(CustomerStaticModel.getuname(), CustomerStaticModel.getpass());
                MessageBox.Show("Update success");
                setData();
            }
            else
            {
                MessageBox.Show("Update failed");

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();  
            Form form1 = new Form2();  
            form.Show();
            this.Dispose();
            form1.Dispose();
        }
    }
}
