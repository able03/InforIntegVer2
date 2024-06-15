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
    public partial class AccountForm : Form
    {
        private DBHelper dBHelper;
        public AccountForm()
        {
            InitializeComponent();

            tbxPassword.PasswordChar = '\u25CF';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dBHelper = new DBHelper();

            try
            {
                if (dBHelper.addAdmin(tbxUname.Text, tbxPassword.Text, 1))
                {
                    MessageBox.Show("Admin registered");
                }
                else
                {
                    MessageBox.Show("Admin registration failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Admin registration failed");
            }
        }
    }
}
