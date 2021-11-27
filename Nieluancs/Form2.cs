using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nieluancs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "admin" && txtpass.Text=="admin"){
                home H = new home();
                this.Hide();
                H.Show();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
            }
        }

        private void lbcancel_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
