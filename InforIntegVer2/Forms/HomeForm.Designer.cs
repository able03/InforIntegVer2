namespace InforIntegVer2
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeItemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.homeTopPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homeTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeItemsPanel
            // 
            this.homeItemsPanel.BackColor = System.Drawing.Color.White;
            this.homeItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeItemsPanel.Location = new System.Drawing.Point(0, 0);
            this.homeItemsPanel.Name = "homeItemsPanel";
            this.homeItemsPanel.Size = new System.Drawing.Size(800, 450);
            this.homeItemsPanel.TabIndex = 1;
            // 
            // homeTopPanel
            // 
            this.homeTopPanel.BackColor = System.Drawing.Color.White;
            this.homeTopPanel.Controls.Add(this.textBox1);
            this.homeTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeTopPanel.Location = new System.Drawing.Point(0, 0);
            this.homeTopPanel.Name = "homeTopPanel";
            this.homeTopPanel.Size = new System.Drawing.Size(800, 37);
            this.homeTopPanel.TabIndex = 2;
            this.homeTopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homeTopPanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeTopPanel);
            this.Controls.Add(this.homeItemsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.homeTopPanel.ResumeLayout(false);
            this.homeTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel homeItemsPanel;
        private System.Windows.Forms.Panel homeTopPanel;
        private System.Windows.Forms.TextBox textBox1;
    }
}