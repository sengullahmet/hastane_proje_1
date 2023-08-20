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
using System.Text.RegularExpressions;

namespace hastane_proje_1
{
    public partial class FrmPatientLogincs : Form
    {
        public FrmPatientLogincs()
        {
            {
                InitializeComponent();
            }
        }
        
      

        private void button1_Click(object sender, EventArgs e)
        {

            mskdTxt.Text = "";
            txtpassword.Text = "";


        }

        private void lnkSıgnUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientSignUp sign = new PatientSignUp();
            sign.Show();
            this.Hide();

        }
        sqlConnection cnnct = new sqlConnection();
      

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlCommand kmt = new SqlCommand("select * from tbl_Patients where patientTC=@tc and patientPass=@password", cnnct.connection());
            kmt.Parameters.AddWithValue("@tc", mskdTxt.Text);
            kmt.Parameters.AddWithValue("@password", txtpassword.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetail ptnt = new FrmPatientDetail();
                ptnt.tc = mskdTxt.Text;
                ptnt.Show();
                this.Hide();
            }
           
            else
            {
                MessageBox.Show("Have a Found For TC or PASSWORD..Please Try Again.");
            }

            cnnct.connection().Close();



        }

        

       
    }
}
