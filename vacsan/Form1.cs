using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vacsan
{
    public partial class Form1 : Form
    {
        private Admin admin;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            admin = new Admin("arsah","f",1234,true,1234,"hmd",new DateTime(2000,3,25),"arash","12345");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == admin.password && txtUsername.Text == admin.userName)
            {
                Form2 administration = new Form2(admin);
                this.Hide();
                administration.ShowDialog();
                this.Close();
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtpassword.Text = string.Empty;
                MessageBox.Show("Username or Password is incorrect", "error");

            }
        }
    }
}
