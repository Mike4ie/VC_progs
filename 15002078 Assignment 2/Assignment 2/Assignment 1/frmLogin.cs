using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_3
{
    public partial class frmLogin : Form 
    {
        public frmLogin()
        {
        InitializeComponent();

        frmSchedule frmSchedule = new frmSchedule();
        frmLogin frmLog = new frmLogin();
        frmLog.Hide();
        frmSchedule.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objDBConnect = new DBConnect();
                objDBConnect.OpenConnection();

               
                
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool checkLogin(string user, string pass)
        {
            
                string username;
                string password;
                var line = "";
                bool isFound = false; // sentinal value
            try
            {
                StreamReader sr = new StreamReader(@"Login.txt"); //literal string
                while (((line = sr.ReadLine()) != null) && (isFound != true))
                {
                    dynamic[] temp = line.Split(',');
                  //  username = temp[0];
                   // password = temp[1];
                    if ((user.Equals(user))&&(pass.Equals(pass)))
	                    {
	                    isFound = true;
	                    }
                    
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                 return false;
            }
            return isFound;
           
        }

    }
}