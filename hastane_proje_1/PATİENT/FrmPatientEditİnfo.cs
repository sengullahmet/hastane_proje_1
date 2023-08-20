using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_proje_1
{
    public partial class FrmPatientEditİnfo : Form
    {
        public FrmPatientEditİnfo()
        {
            InitializeComponent();
        }
        public string Tcno;
        public string name;
        public string surname;
        sqlConnection bgl=new sqlConnection();  

        private void FrmPatientEditİnfo_Load(object sender, EventArgs e)
        {

            mskdTc.Text = Tcno;


        }

        private void BtnEditİnfo_Click(object sender, EventArgs e)
        {

            SqlCommand kmt = new SqlCommand("update tbl_Patients set patientName=@p1,patientSurname=@p2,patientTC=@p3,patientTelephone=@p4,patientPass=@p5,patientGender=@p6",bgl.connection());
            kmt.Parameters.AddWithValue("@p1", txtName.Text);
            kmt.Parameters.AddWithValue("@p2", txtSurname.Text);
            kmt.Parameters.AddWithValue("@p3", mskdTc.Text);
            kmt.Parameters.AddWithValue("@p4", mskdTel.Text);
            kmt.Parameters.AddWithValue("@p5", txtPassword.Text);
            kmt.Parameters.AddWithValue("@p6", cmbGender.Text);
            kmt.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Succesfull Update For Patient İnfo", "İnformation");





        }
    }
}
