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
    public partial class RegisterForm : Form
    {
        private DBHelper dbHelper;
        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tbxPass.PasswordChar = '\u25CF';
        }

        private void btnLoginHere_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dbHelper = new DBHelper();
            string fname = tbxFname.Text;
            string mname = tbxMname.Text;
            string lname = tbxLname.Text;
            string contact= tbxContact.Text;
            string email = tbxEmail.Text;
            string address = tbxAddress.Text;
            string uname = tbxUname.Text;
            string pass = tbxPass.Text;
            if (dbHelper.addCustomer(fname, mname, lname, contact, email, address, uname, pass)) 
            {
                MessageBox.Show("Register success");
                Form form = new LoginForm();
                form.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Register failed");
            }
            
        }
    }
}
