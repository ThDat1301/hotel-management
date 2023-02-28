using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "thdat" && txtPassword.Text == "123")
            {
                lbErrorLogin.Visible = false;
                Dashboard db = new Dashboard();
                this.Hide();
                db.Show();

            }
            else
            {
                txtPassword.Clear();
                lbErrorLogin.Visible = true;
            }
                
        }
    }
}
