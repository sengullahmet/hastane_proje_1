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

namespace hastane_proje_1.SECRETARY
{
    public partial class FrmBranchPanel : Form
    {
        public FrmBranchPanel()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();

        private void FrmBranchPanel_Load(object sender, EventArgs e)
        {
            // Listed All Branch From Database to DataGridView //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_Branch",bgl.connection());
            da.Fill(dt);
            dgwBranchList.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into tbl_Branch (branchName) values (@p1) ",bgl.connection());
            kmt.Parameters.AddWithValue("@p1",txtBranchName.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Branch Name Added !!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.connection().Close();


        }

        private void dgwBranchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView Writing Click Event //
            int choose = dgwBranchList.SelectedCells[0].RowIndex;
            txtİd.Text = dgwBranchList.Rows[choose].Cells[0].Value.ToString();
            txtBranchName.Text = dgwBranchList.Rows[choose].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("delete from tbl_Branch where branchİd=@p1",bgl.connection());
            kmt.Parameters.AddWithValue("@p1",txtİd.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Delete Process İs Successfull !!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlCommand kmt = new SqlCommand("update tbl_Branch set branchName=@p1 where branchİd=@p2", bgl.connection());
            kmt.Parameters.AddWithValue("@p1",txtBranchName.Text);
            kmt.Parameters.AddWithValue("@p2", txtİd.Text);
            kmt.ExecuteNonQuery();
            MessageBox.Show("Update Process İs Successfull !!","İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin open = new FrmSecretaryLogin();
            open.Show();
            this.Hide();

        }
    }
}
