using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace prjMicaDIY
{
    class DBConnect
    {
        public SqlConnection sqlConn;
        public SqlCommand sqlCmd;
        public SqlDataReader sqlDR;
        public SqlDataAdapter sqlDA;

        public void OpenConnection()
        {
            try // connect to database
            {
                sqlConn = new SqlConnection();  // note literal string
                sqlConn.ConnectionString = (@"Data Source = VCDNSTDST04PC13\VARSITYCOLLEGE; Initial catalog = MicaDiy; Integrated Security = SSPI");
                    sqlConn.Open();
                    MessageBox.Show("Connection Successful");


            }
            catch(Exception ex)
            {
             MessageBox.Show( ex.Message); 
            }
        }

        // selct method  contains sql select statement, parse as paramenter
    } // sqlCmd create object of sqlCmd set comand text to select statement , set command type to commandType.text set connect to connection string
    // sqlDR= sqlCMD.executeReader , return sqlDR
   

}
