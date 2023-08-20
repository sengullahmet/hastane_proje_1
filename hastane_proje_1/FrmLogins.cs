using hastane_proje_1.SECRETARY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_proje_1
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPatientLogincs shwing = new FrmPatientLogincs();
            shwing.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin dctor = new FrmDoctorLogin();
            dctor.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin scretary = new FrmSecretaryLogin();
            scretary.Show();
            this.Hide();
        }
    }
}
