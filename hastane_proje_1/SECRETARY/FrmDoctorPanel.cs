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

namespace hastane_proje_1.SECRETARY
{
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            
           
            // All Doctors Selected Database Added DataGridView //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_doctors", bgl.connection());
            da.Fill(dt);
            dgwDoctorList.DataSource = dt;  

            // Selected All Branch's Name  Added to Combobox //

            SqlCommand kmt=new SqlCommand("select branchName from tbl_Branch",bgl.connection());
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
                cmbBranch.Items.Add(dr[0].ToString());
            }
            bgl.connection().Close();







        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {


            SqlCommand kmt = new SqlCommand("insert into tbl_doctors (doctorName,doctorSurname,doctorBranch,doctorTc,doctorPass) values(@p1,@p2,@p3,@p4,@p5) ",bgl.connection());
            kmt.Parameters.AddWithValue("@p1",txtName.Text);
            kmt.Parameters.AddWithValue("@p2", txtSurname.Text);
            kmt.Parameters.AddWithValue("@p3", cmbBranch.Text);
            kmt.Parameters.AddWithValue("@p4", mskTc.Text);
            kmt.Parameters.AddWithValue("@p5", txtPassword.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Successfull Apply", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.connection().Close();
            


                
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select *from tbl_doctors",bgl.connection());
            bgl.connection().Close();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("delete from tbl_doctors where doctorTc=@p1 ", bgl.connection());
            kmt2.Parameters.AddWithValue("@p1", mskTc.Text);
            kmt2.ExecuteNonQuery();
            MessageBox.Show("Register Deleted İs Successfull !!","İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand kmt3 = new SqlCommand("update tbl_doctors set doctorName=@p1,doctorSurname=@p2,doctorBranch=@p3, doctorPass=@p5 where  doctorTc=@p4", bgl.connection());
            kmt3.Parameters.AddWithValue("@p1", txtName.Text);
            kmt3.Parameters.AddWithValue("@p2", txtSurname.Text);
            kmt3.Parameters.AddWithValue("@p3", cmbBranch.Text);
            kmt3.Parameters.AddWithValue("@p4", mskTc.Text);
            kmt3.Parameters.AddWithValue("@p5", txtPassword.Text);

            kmt3.ExecuteNonQuery();
            MessageBox.Show("Update Process İs Successfull !!","İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.connection().Close();
            

        }

        private void dgwDoctorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dgwDoctorList.SelectedCells[0].RowIndex;

            txtName.Text = dgwDoctorList.Rows[choose].Cells[1].Value.ToString();
            txtSurname.Text= dgwDoctorList.Rows[choose].Cells[2].Value.ToString();
            cmbBranch.Text= dgwDoctorList.Rows[choose].Cells[3].Value.ToString();
            mskTc.Text= dgwDoctorList.Rows[choose].Cells[4].Value.ToString();
            txtPassword.Text= dgwDoctorList.Rows[choose].Cells[5].Value.ToString();


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin open = new FrmSecretaryLogin();
            open.Show();
            this.Hide();
        }
    }
}
