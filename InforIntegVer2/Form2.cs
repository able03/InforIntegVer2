using InforIntegVer2.Forms;
using System;

using System.Windows.Forms;

namespace InforIntegVer2
{
    public partial class Form2 : Form
    {
        private Form activeForm;
        private Form main;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            setForm(new HomeForm());
            main = this as Form;
        }

        public Form GetForm() { return main; }

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
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setForm(new HomeForm());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            setForm(new OrdersForm());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            setForm(new ProfileForm());
        }
    }
}
