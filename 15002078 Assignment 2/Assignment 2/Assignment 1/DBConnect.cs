using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment_3
{
    class DBConnect
    {

        public SqlConnection sqlConn;
        public SqlCommand sqlCmd;
        public SqlDataReader sqlDR;
        public SqlDataAdapter sqlDA;
        //VCDNSTDST04PC13\\VARSITYCOLLEGE
        public void OpenConnection()
        {
            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = (@"Data Source=(local);Initial Catalog=APPOINTMENTS;Integrated Security=True");
                sqlConn.Open();
               

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GiveCommand(string sSql)
        {
            try
            {
                OpenConnection();
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandText = sSql;
                 
            
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

 

      

    }
}
