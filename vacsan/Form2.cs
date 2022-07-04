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
    public partial class Form2 : Form
    {
        private string name;
        public Form2(Admin a)
        {
            name = $"{a.name}  {a.lastname}";
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = $"Welcome {name}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ","Log out ",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 loging = new Form1();
                this.Hide();
                loging.ShowDialog();
                this.Close();
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Form4 addpatient = new Form4();
            addpatient.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 addvacsine = new Form3();
            addvacsine.ShowDialog();
        }
    }
}
