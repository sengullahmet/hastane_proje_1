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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }
        sqlConnection bgl=new sqlConnection();
      

        public string tcno;
        private void button1_Click(object sender, EventArgs e)
        {
            mskdTxt.Text = "";
            txtpassword.Text = "";
        }
       
        private void FrmSecretaryLogin_Load(object sender, EventArgs e)
        {
          
       

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Checking Secretary information //

            SqlCommand kmt = new SqlCommand("select * from tbl_secretary  where secretaryTc=@p1 and secretaryPass=@p2 ", bgl.connection());
            kmt.Parameters.AddWithValue("@p1",mskdTxt.Text);
            kmt.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = kmt.ExecuteReader();

            if (dr.Read())
            {
                FrmSecretaryDetails fr = new FrmSecretaryDetails();
                fr.Tc = mskdTxt.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Tc Or Password Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

 
           


        }
    }
}
