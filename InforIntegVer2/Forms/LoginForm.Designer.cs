using System.Windows.Forms;

namespace InforIntegVer2.Forms
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxUname = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegisterHere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(35, 270);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(209, 35);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxUname
            // 
            this.tbxUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUname.Location = new System.Drawing.Point(12, 79);
            this.tbxUname.Name = "tbxUname";
            this.tbxUname.Size = new System.Drawing.Size(271, 30);
            this.tbxUname.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(102, 25);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Username";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(12, 171);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(271, 30);
            this.tbxPassword.TabIndex = 9;
            this.tbxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(41, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Don\'t have an account?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRegisterHere
            // 
            this.btnRegisterHere.FlatAppearance.BorderSize = 0;
            this.btnRegisterHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterHere.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRegisterHere.Location = new System.Drawing.Point(163, 303);
            this.btnRegisterHere.Name = "btnRegisterHere";
            this.btnRegisterHere.Size = new System.Drawing.Size(81, 23);
            this.btnRegisterHere.TabIndex = 11;
            this.btnRegisterHere.Text = "Register here";
            this.btnRegisterHere.UseVisualStyleBackColor = true;
            this.btnRegisterHere.Click += new System.EventHandler(this.btnRegisterHere_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 374);
            this.Controls.Add(this.btnRegisterHere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxUname);
            this.Controls.Add(this.lbl);
            this.Name = "LoginForm";
            this.Text = "LoginFotm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxUname;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegisterHere;
    }
}