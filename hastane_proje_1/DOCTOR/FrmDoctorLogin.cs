using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using hastane_proje_1.DOCTOR;

namespace hastane_proje_1
{
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            mskdTxt.Text = "";
            txtpassword.Text = ""; 
        }

        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select *from tbl_doctors  where doctorTc=@p1 and doctorPass=@p2", bgl.connection());
            kmt.Parameters.AddWithValue("@p1",mskdTxt.Text);
            kmt.Parameters.AddWithValue("@p2",txtpassword.Text);
            SqlDataReader dr = kmt.ExecuteReader();

            if (dr.Read())
            {
                FrmDoctorDetails open = new FrmDoctorDetails();
                open.Tc = mskdTxt.Text;
                open.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Have a Found For Idenıty or Password !!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
