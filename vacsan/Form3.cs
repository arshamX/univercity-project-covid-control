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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Vacsin newvacsin = new Vacsin(txtname.Text.ToString(), txtcountry.Text.ToString(), Convert.ToInt32(nudcount.Value));
                Program.vacsins.Add(newvacsin);
                MessageBox.Show("vacsine successfully added","success");
            }
            catch
            {
                MessageBox.Show("some thing went wrong", "Error");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
