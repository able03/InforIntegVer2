using InforIntegVer2.Forms;
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
    public partial class BaseForm : Form
    {
        private Form activeForm;
        public BaseForm()
        {
            InitializeComponent();
            setForm(new HomeForm());
        }

        public void setForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(form);
            this.panel2.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            setForm(new HomeForm());
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            setForm(new Inventory());
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            setForm(new AccountForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.Show();
            this.Dispose();
        }
    }


}
