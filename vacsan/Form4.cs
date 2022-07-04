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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            if(Program.vacsins.Count == 0 )
            {
                MessageBox.Show("No vacsins available");
            }
            else
            {
                foreach(Vacsin vacsin in Program.vacsins)
                {
                    if(vacsin.doescount > 0)
                    { cbVacsin.Items.Add(vacsin.name); }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                if (rbMale.Checked)
                {
                    flag = true;
                }
                else if (rbFmale.Checked)
                    flag = false;

                Patient patient = new Patient(txtName.Text, txtLast.Text, Int32.Parse(txtNational.Text), flag, Int32.Parse(txtPhone.Text), txtAd.Text, dateBirth.Value, Convert.ToInt16(nudDoes.Value));
                Program.patients.Add(patient);
                MessageBox.Show($"Patianet add succsessfull and next date of injection is {patient.dateDoes2}", "success");
            }
            catch
            {
                MessageBox.Show("Error", "error");
            }
        }
    }
}
