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
    public partial class FrmDoctorInfoEdit : Form
    {
        public FrmDoctorInfoEdit()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();

       
        public string Tc;
        private void FrmDoctorInfoEdit_Load(object sender, EventArgs e)
        {
            mskdTc.Text = Tc;

            SqlCommand kmt = new SqlCommand("select doctorName,doctorSurname,doctorBranch,doctorPass from tbl_doctors where doctorTc=@p1 ", bgl.connection());
            kmt.Parameters.AddWithValue("@p1", mskdTc.Text);
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
                txtName.Text = dr[0].ToString();
                txtSurname.Text = dr[1].ToString();
                cmbBranch.Text = dr[2].ToString();
                txtPassword.Text = dr[3].ToString();
            }
            bgl.connection().Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("update tbl_doctors set doctorName=@p1,doctorSurname=@p2,doctorBranch=@p4,doctorPass=@p5 where doctorTc=@p3 ", bgl.connection());
            kmt.Parameters.AddWithValue("@p1", txtName.Text);
            kmt.Parameters.AddWithValue("@p2", txtSurname.Text);
            kmt.Parameters.AddWithValue("@p4", cmbBranch.Text);
            kmt.Parameters.AddWithValue("@p3", mskdTc.Text);
            kmt.Parameters.AddWithValue("@p5", txtPassword.Text);

            kmt.ExecuteNonQuery();
            DialogResult result=MessageBox.Show("Update İs Successfull !!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.connection().Close();


           // Updated İnformation From Database And Again Go to Login Panel //
            if (result == DialogResult.OK)
            {
                FrmDoctorLogin open = new FrmDoctorLogin();
                open.Show();
                this.Hide();
            }





        }


    }
}
