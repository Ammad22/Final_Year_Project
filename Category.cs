using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OrderManagementSysytem
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SqlConnection connection { get; set; }


        public bool insert()
        {
            SqlCommand cmd = new SqlCommand("CategoryInsert",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name",this.Name);
            


             int check = cmd.ExecuteNonQuery();
            if (check !=0)
            {
                return true;        
            }
            else
            {
                return false;
            }
              }
        public void updtae()
        {
            SqlCommand cmd = new SqlCommand("Category_Update",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", this.Id);
            cmd.Parameters.AddWithValue("@Name",this.Name);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Close();
        }

        public void delete()
        {
            SqlCommand cmd = new SqlCommand("Category_Delete", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",this.Id);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Close();
        }


        }
    }

