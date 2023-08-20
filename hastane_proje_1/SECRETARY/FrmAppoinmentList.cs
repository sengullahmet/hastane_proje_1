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
    public partial class FrmAppoinmentList : Form
    {
        public FrmAppoinmentList()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
       

        private void FrmAppoinmentList_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Appoinments",bgl.connection());
            da.Fill(dt);
            dgwApoinmentListed.DataSource = dt;


        }

     
        private void returnBtn_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin open =  new FrmSecretaryLogin();
            open.Show();
            this.Hide();

        }
    }
}
