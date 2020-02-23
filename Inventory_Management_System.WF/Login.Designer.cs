namespace Inventory_Management_System.WF
{
    partial class Login
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.txtuser = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroLabel();
            this.uname = new MetroFramework.Controls.MetroLabel();
            this.signup = new MetroFramework.Controls.MetroButton();
            this.loginbtm = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 364);
            this.panel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Lavender;
            this.metroPanel1.Controls.Add(this.txtpass);
            this.metroPanel1.Controls.Add(this.txtuser);
            this.metroPanel1.Controls.Add(this.password);
            this.metroPanel1.Controls.Add(this.uname);
            this.metroPanel1.Controls.Add(this.signup);
            this.metroPanel1.Controls.Add(this.loginbtm);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(184, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(347, 208);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(139, 98);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(170, 23);
            this.txtpass.TabIndex = 7;
            this.txtpass.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(139, 58);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(170, 23);
            this.txtuser.TabIndex = 6;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(49, 102);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(63, 19);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uname.Location = new System.Drawing.Point(49, 62);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(68, 19);
            this.uname.TabIndex = 4;
            this.uname.Text = "Username";
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(234, 146);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 23);
            this.signup.TabIndex = 3;
            this.signup.Text = "Sign Up";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // loginbtm
            // 
            this.loginbtm.Location = new System.Drawing.Point(139, 146);
            this.loginbtm.Name = "loginbtm";
            this.loginbtm.Size = new System.Drawing.Size(75, 23);
            this.loginbtm.TabIndex = 2;
            this.loginbtm.Text = "Login";
            this.loginbtm.Click += new System.EventHandler(this.loginbtm_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtpass;
        private MetroFramework.Controls.MetroTextBox txtuser;
        private MetroFramework.Controls.MetroLabel password;
        private MetroFramework.Controls.MetroLabel uname;
        private MetroFramework.Controls.MetroButton signup;
        private MetroFramework.Controls.MetroButton loginbtm;
    }
}

