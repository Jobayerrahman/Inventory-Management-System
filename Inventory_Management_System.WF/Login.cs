using Inventory_Management_System.Data;
using Inventory_Management_System.Framework;
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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void loginbtm_Click(object sender, EventArgs e)
        {
            IMSDBContext context = new IMSDBContext();
            var obj = context.UserInfoes.FirstOrDefault(u => u.UserName.Equals(txtuser.Text) && u.Password.Equals(txtpass.Text));
            if(obj == null)
            {
                MessageBox.Show(this, "Invalid Username anad Password");
                return;
            }

            var up = new UserProfile()
            {
                ID = obj.ID,
                Name= obj.Name,
                UserName = obj.UserName,
                UserTypeID = obj.UserTypeID
            };

            Loginhelper.UserProfile = up;

            if (obj.UserTypeID == (int) EnumCollection.UserTypeEnum.Admin)
            {
                Admin am = new Admin();
                am.Show();
            }
            else if (obj.UserTypeID == (int)EnumCollection.UserTypeEnum.Employee)
            {
                Employee am = new Employee();
                am.Show();
            }
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
            this.Hide();
        }
    }
}
