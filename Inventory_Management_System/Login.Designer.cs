namespace Inventory_Management_System
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
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uname = new System.Windows.Forms.Label();
            this.usertextbox = new System.Windows.Forms.TextBox();
            this.loginbtm = new System.Windows.Forms.Button();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.signbtm = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(372, 93);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl1.TabIndex = 0;
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 364);
            this.panel1.TabIndex = 0;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(46, 38);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(86, 19);
            this.uname.TabIndex = 0;
            this.uname.Text = "Username :";
            // 
            // usertextbox
            // 
            this.usertextbox.Location = new System.Drawing.Point(154, 37);
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.Size = new System.Drawing.Size(179, 20);
            this.usertextbox.TabIndex = 1;
            // 
            // loginbtm
            // 
            this.loginbtm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtm.Location = new System.Drawing.Point(154, 143);
            this.loginbtm.Name = "loginbtm";
            this.loginbtm.Size = new System.Drawing.Size(75, 32);
            this.loginbtm.TabIndex = 2;
            this.loginbtm.Text = "Login";
            this.loginbtm.UseVisualStyleBackColor = true;
            // 
            // passtextbox
            // 
            this.passtextbox.Location = new System.Drawing.Point(154, 86);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.PasswordChar = '*';
            this.passtextbox.Size = new System.Drawing.Size(179, 20);
            this.passtextbox.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(46, 87);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(81, 19);
            this.password.TabIndex = 4;
            this.password.Text = "Password :";
            // 
            // signbtm
            // 
            this.signbtm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbtm.Location = new System.Drawing.Point(258, 143);
            this.signbtm.Name = "signbtm";
            this.signbtm.Size = new System.Drawing.Size(75, 32);
            this.signbtm.TabIndex = 5;
            this.signbtm.Text = "Sign Up";
            this.signbtm.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.signbtm);
            this.metroPanel1.Controls.Add(this.password);
            this.metroPanel1.Controls.Add(this.usertextbox);
            this.metroPanel1.Controls.Add(this.passtextbox);
            this.metroPanel1.Controls.Add(this.uname);
            this.metroPanel1.Controls.Add(this.loginbtm);
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(180, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(384, 213);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button signbtm;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usertextbox;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Button loginbtm;
    }
}