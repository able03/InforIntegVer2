using InforIntegVer2.Admin_Forms;
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
    public partial class LoginForm : Form
    {
        private Form activeForm;
        private DBHelper dbHelper;
       
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            tbxPassword.PasswordChar = '\u25CF';
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisteHere_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegisterHere_Click(object sender, EventArgs e)
        {
            Form form = new RegisterForm();
            form.Show();
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbHelper = new DBHelper();

            string uname = tbxUname.Text;
            string pass = tbxPassword.Text;
            if(dbHelper.getAdmin(uname, pass))
            {
                MessageBox.Show("Login success");
                Form form = new BaseForm();
                form.Show();
                this.Dispose();
            }

            else
            {
                if (dbHelper.getCustomer(uname, pass))
                {
                    MessageBox.Show("Login success");
                    Form form = new Form2();
                    form.Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
