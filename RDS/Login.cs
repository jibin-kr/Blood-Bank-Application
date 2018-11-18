using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDS
{
    public partial class Login : Form
    {
        RDSEntities t = new RDSEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DonorHome hm = new DonorHome();
            if (txtPassword.Text == null || txtPassword.Text == " " || TxtUsername.Text == null || TxtUsername.Text == " ")
            {
                lblErrorUser.Show();
            }
            else
            {
                lblErrorUser.Visible = false;
                if (Isvaliduser(TxtUsername.Text, txtPassword.Text) == true)
                {
                    this.Hide();
                    hm.Show();
                }
                else
                {
                    lblErrorUser.Show();
                }
            }

        }
        public bool Isvaliduser(string name, string password)
        {
            var chk = t.Users.Where(s => s.UserName == name && s.Password == password && s.Active == true).FirstOrDefault();
            if (chk == null)
            {
                return false;
            }
         else
            {
                return true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblErrorUser.Visible = false;
            
        }
   

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblErrorUser.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblErrorUser_Click(object sender, EventArgs e)
        {

        }
    }
}
