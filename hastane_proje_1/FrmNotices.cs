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
using hastane_proje_1.SECRETARY;

namespace hastane_proje_1
{
    public partial class FrmNotices : Form
    {
        public FrmNotices()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();

        private void FrmNotices_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from tbl_notifications", bgl.connection());
            da.Fill(dt);
            dgswNotices.DataSource = dt;


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin open = new FrmSecretaryLogin();
            open.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin open=new FrmDoctorLogin();
            open.Show();
            this.Hide();
        }
    }
}
