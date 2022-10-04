using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Data;
namespace simple_email_management
{
    class clsDla
    {
        private static string connectionStr = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";

        public static bool NONQUERY(string cmd)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionStr);
                con.Open();
                SqlCommand com = new SqlCommand(cmd, con);
                com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            return false;
        }
        public static bool validmail(string email)
        {
            try
            {
               new MailAddress(email);
                return true;
            }
            catch { }
            return false;
        }

        public static DataTable Select(string cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionStr);
                SqlDataAdapter da = new SqlDataAdapter(cmd,con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return dt;
            
            
        }

       
        
    }
}
