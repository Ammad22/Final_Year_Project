using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace OrderManagementSysytem
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string price { get; set; }
        public int Category_Id { get; set; }
        public SqlConnection connection { get; set; }
        
        
        public bool insert()
        {
            SqlCommand cmd = new SqlCommand("Item_Insert",connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name",this.Name);
            cmd.Parameters.AddWithValue("@Price",this.price);
            cmd.Parameters.AddWithValue("@Category_Id", this.Category_Id);
            int check = cmd.ExecuteNonQuery();
            if (check != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public void update()
            {
                SqlCommand cmd = new SqlCommand("Item_Update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID",this.Id);
                cmd.Parameters.AddWithValue("@Name",this.Name);
                cmd.Parameters.AddWithValue("@Price", this.price);
                cmd.Parameters.AddWithValue("@Category_ID", this.Category_Id);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();

                  
            }
            public void delete()
            {
                SqlCommand cmd = new SqlCommand("@Item_Delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", this.Id);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();
            }


        

        }
    }

