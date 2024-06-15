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
    public partial class HomeForm : Form
    {
        private DBHelper dBHelper;
        public HomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            initValues();
            setData();
            


            
        }

        private void initValues()
        {
            dBHelper = new DBHelper();
        }

     


        private void setData()

        {
            List<TestUC> items = dBHelper.getProductList();
           
            foreach (TestUC item in items)
            {
                homeItemsPanel.Controls.Add(item);
            }

            
        }


        /*private void setGrid()
        {
            dataGridView = new DataGridView();
            //dataGridView.Dock = DockStyle.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.RowTemplate.Height = 200;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "ImageColumn";
            imageColumn.HeaderText = "Image";
            dataGridView1.Columns.Add(imageColumn);

            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.Name = "TextColumn";
            textColumn.HeaderText = "Text";
            dataGridView1.Columns.Add(textColumn);

            dataGridView1.Rows.Add(Image.FromFile("C:\\Users\\alice\\source\\repos\\InforIntegVer2\\InforIntegVer2\\Resources\\biogesic.png"), "Text 1");
            dataGridView1.Rows.Add(Image.FromFile("C:\\Users\\alice\\source\\repos\\InforIntegVer2\\InforIntegVer2\\Resources\\cetirizine.png"), "Text 2");

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            //homeItemsPanel.Controls.Add(dataGridView);
        
          
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        
        private void btn_Click(object sender, EventArgs e)
        {


        }

       
        private void homeTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
