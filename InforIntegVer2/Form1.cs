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
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Pharmacy";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadForm(Form form)
        {
            // Remove existing controls from the mainPanel
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            // Set the new form properties
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Add the new form to the mainPanel and show it
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }

        public void setForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = form;
            form.TopLevel= false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.BringToFront();
            form.Show();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setForm(new HomeForm());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setForm(new Search());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

           if (this.menuPanel.Visible = true)
            {
                this.menuPanel.Visible = false;
            }
           else
            {
                this.menuPanel.Visible= true;
            }
        }
    }
}
