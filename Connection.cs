using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSysytem
{
    public class Connection
    {
        public static SqlConnection sc;
        public static string dbCon =@"Data Source=.\sql08;Initial Catalog=Order_management;Integrated Security=True";

        public static SqlConnection get()
        {
            if (sc == null)
            {
                sc = new SqlConnection();
                sc.ConnectionString = dbCon;
                sc.Open();
            }

            return sc;
        }
    }
}
