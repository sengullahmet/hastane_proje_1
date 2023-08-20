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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }
        
        FrmPatientLogincs frm = new FrmPatientLogincs();
        public string tc;

        sqlConnection bgl = new sqlConnection();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;

            //// Pull To(Çekmek)  Patient Name Surname Selected database

            SqlCommand kmt = new SqlCommand("select patientName,patientSurname from tbl_Patients", bgl.connection());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0] + "-" + dr[1];

            }
            bgl.connection().Close();




            // Appoinment History

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Appoinments where PatientTc=" + tc, bgl.connection());
            da.Fill(dt);
            dgwHıstoryApp.DataSource = dt;


            // Pull To(Çekmek) Branch's

            SqlCommand kmt1 = new SqlCommand("select branchName from tbl_Branch", bgl.connection());
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBranch.Items.Add(dr1[0]);
            }
            bgl.connection().Close();


        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pull Branch Name Listed Doctor Name
            cmbDoctor.Items.Clear();
            SqlCommand kmt3 = new SqlCommand("select doctorName,doctorSurname from tbl_doctors where doctorBranch=@p8 ", bgl.connection());
            kmt3.Parameters.AddWithValue("@p8", cmbBranch.Text);
            SqlDataReader dr = kmt3.ExecuteReader();
            while (dr.Read())
            {
                cmbDoctor.Items.Add(dr[0] + " - " + dr[1]);
            }
            bgl.connection().Close();


















        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from Appoinments where AppoinmentBranch='"+cmbBranch.Text+"'",bgl.connection());
            da.Fill(dt);
            dgwActApp.DataSource = dt;
            















        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientEditİnfo fr = new FrmPatientEditİnfo();
            fr.Tcno = lblTc.Text;

            SqlCommand kmt = new SqlCommand("select patientName,patientSurname,patientTC,patientTelephone,patientPass,patientGender   from tbl_Patients", bgl.connection());
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                fr.txtName.Text = dr[0].ToString();
                fr.txtSurname.Text = dr[1].ToString();
                fr.mskdTc.Text = dr[2].ToString();
                fr.mskdTel.Text = dr[3].ToString();
                fr.txtPassword.Text = dr[4].ToString();
                fr.cmbGender.Text = dr[5].ToString();


            }
            bgl.connection().Close();

            
            fr.Show();
            this.Hide();

        }

        private void dgwActApp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dgwActApp.SelectedCells[0].RowIndex;

            txtİd.Text = dgwActApp.Rows[choose].Cells[0].Value.ToString();



        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {

            SqlCommand kmt = new SqlCommand("update Appoinments set Appoinment=1,PatientTc=@p1,Complaint=@p2 where Appoinmentİd=@p3", bgl.connection());
            kmt.Parameters.AddWithValue("@p1", lblTc.Text);
            kmt.Parameters.AddWithValue("@p2", rchComplaint.Text);
            kmt.Parameters.AddWithValue("@p3", txtİd.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Appoinment İs Successfull !!", "İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);

           



        }
    }
}
