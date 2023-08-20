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
using System.Net.Http.Headers;

namespace hastane_proje_1.SECRETARY
{
    public partial class FrmSecretaryDetails : Form
    {
      
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        FrmSecretaryLogin lgn=new FrmSecretaryLogin();

        public string Tc;


      


        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            lblTc.Text = Tc;

            // Selected Name Surname  From Database //

            sqlConnection bgl = new sqlConnection();
            SqlCommand kmt = new SqlCommand("select secretaryNameSurname from tbl_secretary where secretaryTc=@p1 ", bgl.connection());
            kmt.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                 lblNameSurname.Text= dr[0].ToString();

            }
            bgl.connection().Close();


            // Selected Branch From Database //

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_Branch",bgl.connection());
            da.Fill(dt);
            dgwBranches.DataSource = dt;




            // Selected Doctor'S From Database //

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doctorName+''+doctorSurname) as Doctors,doctorBranch from tbl_doctors ", bgl.connection());
            da1.Fill(dt1);
            dgwDoctors.DataSource = dt1;


            // Selected Branch's İn Combobox //

            SqlCommand kmt2 = new SqlCommand("select branchName from tbl_Branch",bgl.connection());
            SqlDataReader dr2 = kmt2.ExecuteReader();

            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0].ToString());
            }
            bgl.connection().Close();














        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("insert into Appoinments (AppoinmentDate,AppoinmentHour,AppoinmentBranch,AppoinmentDoctor) values (@p1,@p2,@p3,@p4) ", bgl.connection());
            kmt3.Parameters.AddWithValue("@p1",mskDate.Text);
            kmt3.Parameters.AddWithValue("@p2", mskHour.Text);
            kmt3.Parameters.AddWithValue("@p3", cmbBranch.Text);
            kmt3.Parameters.AddWithValue("@p4", cmbDoctor.Text);

            kmt3.ExecuteNonQuery();
            MessageBox.Show("Successful Apply For Appoinments Register !", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

            // List Doctors Selected By Combobox Data //
            cmbDoctor.Items.Clear();
            SqlCommand kmt3 = new SqlCommand("select doctorName,doctorSurname from tbl_doctors where doctorBranch=@p1",bgl.connection());
            kmt3.Parameters.AddWithValue("@p1",cmbBranch.Text);
            SqlDataReader dr3 = kmt3.ExecuteReader();

            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + "  " + dr3[1]);
            }
            bgl.connection().Close();





        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            SqlCommand kmt4 = new SqlCommand("insert into tbl_notifications  (notifications) values(@p1) ", bgl.connection());
            kmt4.Parameters.AddWithValue("@p1", rchNotice.Text);
            kmt4.ExecuteNonQuery();
            MessageBox.Show("Notice Apply İs Successfull !!","İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.connection().Close();


        }

        private void btnDctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel dctrpnl=new FrmDoctorPanel();
            dctrpnl.Show();
            this.Hide();

        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranchPanel open = new FrmBranchPanel();
            open.Show();
            this.Hide();


        }

        private void btnApoinListed_Click(object sender, EventArgs e)
        {
            FrmAppoinmentList open = new FrmAppoinmentList();
            open.Show();
            this.Hide();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand kmt = new SqlCommand("update Appoinments set AppoinmentDate=@p1,AppoinmentHour=@p2,AppoinmentBranch=@p3,AppoinmentDoctor=@p4,Appoinment=@p5,PatientTc=@p6  where Appoinmentİd=@p7  ", bgl.connection());
                kmt.Parameters.AddWithValue("@p1", mskDate.Text);
                kmt.Parameters.AddWithValue("@p2", mskHour.Text);
                kmt.Parameters.AddWithValue("@p3", cmbBranch.Text);
                kmt.Parameters.AddWithValue("@p4", cmbDoctor.Text);
                kmt.Parameters.AddWithValue("@p5", chckState.Text);
                kmt.Parameters.AddWithValue("@p6", mmskTc.Text);
                kmt.Parameters.AddWithValue("@p7", txtİd.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Update İs Successfull !!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bgl.connection().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Don't Null TextField's !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txtİd_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Please Enter Carefully and True Value Appoinment 'İd'\n İf Your Entry İd Whereas İs True Then Not Disregard ", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            FrmNotices open = new FrmNotices();
            open.Show();
            this.Hide();

        }
    }
}
