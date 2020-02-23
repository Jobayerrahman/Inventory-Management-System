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
    public partial class Employee : MetroFramework.Forms.MetroForm
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login lm = new Login();
            lm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Inventory_listView iv = new Inventory_listView();
            iv.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            InventoryManage im = new InventoryManage();
            im.Show();
            this.Hide();
        }
    }
}
