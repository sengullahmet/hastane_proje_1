using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_proje_1
{
    public class sqlConnection
    {
      public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-SA9H44E;Initial Catalog=MedicalProject;Integrated Security=True");
            connect.Open();
            return connect;

        }




    }
}
