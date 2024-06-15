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
    public partial class LoginRegisForm : Form
    {
        private Form activeForm;
        private Panel panel;
        public LoginRegisForm()
        {
            InitializeComponent();
            setForm(new LoginForm());
            panel = this.panel3;
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
            this.panel3.Controls.Add(form);
            this.panel3.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            setForm(new RegisterForm());
            btnRegister.Text = "Sign in";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            setForm(new LoginForm());
            btnRegister.Text = "Sign un";
        }
    }
}
