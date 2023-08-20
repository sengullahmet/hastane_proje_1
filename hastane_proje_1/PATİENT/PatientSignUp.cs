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

namespace hastane_proje_1
{
    public partial class PatientSignUp : Form
    {
        public PatientSignUp()
        {
            InitializeComponent();
        }
        sqlConnection conncted = new sqlConnection();
       
        private void BtnSign_Click(object sender, EventArgs e)
        {

            SqlCommand kmt = new SqlCommand("insert into tbl_Patients (patientName,patientSurname,patientTC,patientTelephone,patientPass,patientGender) values(@name,@surname,@tc,@telephone,@password,@gender)",conncted.connection());
            kmt.Parameters.AddWithValue("@name", txtName.Text);
            kmt.Parameters.AddWithValue("@surname", txtSurname.Text);
            kmt.Parameters.AddWithValue("@tc", mskdTc.Text);
            kmt.Parameters.AddWithValue("@telephone", mskdTel.Text);
            kmt.Parameters.AddWithValue("@password", txtPassword.Text);
            kmt.Parameters.AddWithValue("@gender", cmbGender.Text);
            kmt.ExecuteNonQuery();
            conncted.connection().Close();
            MessageBox.Show("Your Sign İs Successfull Password :" + txtPassword.Text, "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void PatientSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
           

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
