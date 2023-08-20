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

namespace hastane_proje_1.DOCTOR
{
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }
        public  string Tc;
        sqlConnection bgl = new sqlConnection();

       
        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            lblTc.Text = Tc;
            


            // Selected Name Surname From Database //

            SqlCommand kmt = new SqlCommand("select doctorName,doctorSurname from tbl_doctors  where doctorTc=@p1", bgl.connection());
            kmt.Parameters.AddWithValue("@p1", Tc);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0].ToString() + " " + dr[1].ToString();
            }
            bgl.connection().Close();



            // Listed Appoinments //

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Appoinments where AppoinmentDoctor='"+lblNameSurname.Text+"'",bgl.connection());
            da.Fill(dt);
            dgwAppoinments.DataSource = dt; 









        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorInfoEdit open = new FrmDoctorInfoEdit();
            open.Tc = lblTc.Text;
            open.Show();
            this.Hide();

        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            FrmNotices open = new FrmNotices();
            open.Show();
            this.Hide();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
