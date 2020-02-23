namespace Inventory_Management_System.WF
{
    partial class InventoryManage
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtxt = new MetroFramework.Controls.MetroTextBox();
            this.product = new MetroFramework.Controls.MetroLabel();
            this.searchbtm = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.freshbtm = new MetroFramework.Controls.MetroButton();
            this.editbtm = new MetroFramework.Controls.MetroButton();
            this.deletebtm = new MetroFramework.Controls.MetroButton();
            this.addbtm = new MetroFramework.Controls.MetroButton();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.amount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Producttype = new MetroFramework.Controls.MetroLabel();
            this.productname = new MetroFramework.Controls.MetroLabel();
            this.productid = new MetroFramework.Controls.MetroLabel();
            this.IgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IgvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igvamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.73684F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.26316F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05494F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.94505F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(477, 388);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchtxt);
            this.panel1.Controls.Add(this.product);
            this.panel1.Controls.Add(this.searchbtm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 71);
            this.panel1.TabIndex = 0;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(94, 20);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(180, 23);
            this.searchtxt.TabIndex = 2;
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(20, 24);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(55, 19);
            this.product.TabIndex = 1;
            this.product.Text = "Product";
            // 
            // searchbtm
            // 
            this.searchbtm.Location = new System.Drawing.Point(301, 20);
            this.searchbtm.Name = "searchbtm";
            this.searchbtm.Size = new System.Drawing.Size(75, 23);
            this.searchbtm.TabIndex = 0;
            this.searchbtm.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 305);
            this.panel2.TabIndex = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IgvID,
            this.IgvName,
            this.IgvType,
            this.Igvprice,
            this.Igvamount});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(471, 305);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.freshbtm);
            this.panel3.Controls.Add(this.editbtm);
            this.panel3.Controls.Add(this.deletebtm);
            this.panel3.Controls.Add(this.addbtm);
            this.panel3.Controls.Add(this.metroTextBox5);
            this.panel3.Controls.Add(this.metroTextBox4);
            this.panel3.Controls.Add(this.metroTextBox3);
            this.panel3.Controls.Add(this.metroTextBox2);
            this.panel3.Controls.Add(this.metroTextBox1);
            this.panel3.Controls.Add(this.amount);
            this.panel3.Controls.Add(this.metroLabel4);
            this.panel3.Controls.Add(this.Producttype);
            this.panel3.Controls.Add(this.productname);
            this.panel3.Controls.Add(this.productid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(486, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 388);
            this.panel3.TabIndex = 1;
            // 
            // freshbtm
            // 
            this.freshbtm.Location = new System.Drawing.Point(219, 334);
            this.freshbtm.Name = "freshbtm";
            this.freshbtm.Size = new System.Drawing.Size(75, 23);
            this.freshbtm.TabIndex = 15;
            this.freshbtm.Text = "Refresh";
            // 
            // editbtm
            // 
            this.editbtm.Location = new System.Drawing.Point(219, 279);
            this.editbtm.Name = "editbtm";
            this.editbtm.Size = new System.Drawing.Size(75, 23);
            this.editbtm.TabIndex = 14;
            this.editbtm.Text = "Edit";
            // 
            // deletebtm
            // 
            this.deletebtm.Location = new System.Drawing.Point(65, 334);
            this.deletebtm.Name = "deletebtm";
            this.deletebtm.Size = new System.Drawing.Size(75, 23);
            this.deletebtm.TabIndex = 13;
            this.deletebtm.Text = "Delete";
            // 
            // addbtm
            // 
            this.addbtm.Location = new System.Drawing.Point(65, 279);
            this.addbtm.Name = "addbtm";
            this.addbtm.Size = new System.Drawing.Size(75, 23);
            this.addbtm.TabIndex = 12;
            this.addbtm.Text = "Add";
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.Location = new System.Drawing.Point(142, 229);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox5.TabIndex = 11;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(142, 176);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox4.TabIndex = 10;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(142, 124);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox3.TabIndex = 9;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(142, 79);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox2.TabIndex = 8;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(142, 27);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox1.TabIndex = 7;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(30, 229);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(106, 19);
            this.amount.TabIndex = 6;
            this.amount.Text = "Product Amount";
            this.amount.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 180);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Product Price";
            // 
            // Producttype
            // 
            this.Producttype.AutoSize = true;
            this.Producttype.Location = new System.Drawing.Point(50, 128);
            this.Producttype.Name = "Producttype";
            this.Producttype.Size = new System.Drawing.Size(86, 19);
            this.Producttype.TabIndex = 4;
            this.Producttype.Text = "Product Type";
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Location = new System.Drawing.Point(43, 79);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(95, 19);
            this.productname.TabIndex = 3;
            this.productname.Text = "Product Name";
            // 
            // productid
            // 
            this.productid.AutoSize = true;
            this.productid.Location = new System.Drawing.Point(65, 31);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(71, 19);
            this.productid.TabIndex = 2;
            this.productid.Text = "Product ID";
            // 
            // IgvID
            // 
            this.IgvID.DataPropertyName = "ID";
            this.IgvID.HeaderText = "ProductID";
            this.IgvID.Name = "IgvID";
            this.IgvID.ReadOnly = true;
            // 
            // IgvName
            // 
            this.IgvName.DataPropertyName = "Name";
            this.IgvName.HeaderText = "ProductName";
            this.IgvName.Name = "IgvName";
            this.IgvName.ReadOnly = true;
            // 
            // IgvType
            // 
            this.IgvType.DataPropertyName = "Type";
            this.IgvType.HeaderText = "ProductType";
            this.IgvType.Name = "IgvType";
            this.IgvType.ReadOnly = true;
            // 
            // Igvprice
            // 
            this.Igvprice.DataPropertyName = "Price";
            this.Igvprice.FillWeight = 80F;
            this.Igvprice.HeaderText = "Price";
            this.Igvprice.Name = "Igvprice";
            this.Igvprice.ReadOnly = true;
            this.Igvprice.Width = 80;
            // 
            // Igvamount
            // 
            this.Igvamount.DataPropertyName = "Amount";
            this.Igvamount.HeaderText = "Amount";
            this.Igvamount.Name = "Igvamount";
            this.Igvamount.ReadOnly = true;
            // 
            // InventoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InventoryManage";
            this.Text = "InventoryManage";
            this.Load += new System.EventHandler(this.InventoryManage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox searchtxt;
        private MetroFramework.Controls.MetroLabel product;
        private MetroFramework.Controls.MetroButton searchbtm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel amount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel Producttype;
        private MetroFramework.Controls.MetroLabel productname;
        private MetroFramework.Controls.MetroLabel productid;
        private MetroFramework.Controls.MetroButton freshbtm;
        private MetroFramework.Controls.MetroButton editbtm;
        private MetroFramework.Controls.MetroButton deletebtm;
        private MetroFramework.Controls.MetroButton addbtm;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igvamount;
    }
}