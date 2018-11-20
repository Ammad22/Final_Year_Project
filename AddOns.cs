using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OrderManagementSysytem
{
    class AddOns
    {
        public int Addons_ID { get; set; }
        public string Addons_Name { get; set; }
        public string Addons_Price { get; set; }
        public SqlConnection connection { get; set; }
              public bool insert()
        {
            SqlCommand cmd = new SqlCommand("AddOns_Insert", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(" @Addons_Name", this.Addons_Name);
            cmd.Parameters.AddWithValue("@Addons_Price", this.Addons_Price);
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

                  public void  update()
                  {
                      SqlCommand cmd = new SqlCommand("AddOns_Update", connection);
                      cmd.CommandType = CommandType.StoredProcedure;
                      cmd.Parameters.AddWithValue("@ID",this.Addons_ID);
                      cmd.Parameters.AddWithValue("@Name", this.Addons_Name);
                      cmd.Parameters.AddWithValue("@Price", this.Addons_Price);

                      SqlDataReader sdr = cmd.ExecuteReader();
                      sdr.Close();
                  }
        public void delete()
        {
            SqlCommand cmd = new SqlCommand("AddOns_Delete", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID ", connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Close();



                  }
        

            

        }



    }

