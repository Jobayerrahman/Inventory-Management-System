﻿using Inventory_Management_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.WF
{
    public partial class InventoryManage : MetroFramework.Forms.MetroForm
    {
        public InventoryManage()
        {
            InitializeComponent();
        }

        private void InventoryManage_Load(object sender, EventArgs e)
        {
            IMSDBContext context = new IMSDBContext();
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = context.Products.ToList();
            dgvProduct.Refresh();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
