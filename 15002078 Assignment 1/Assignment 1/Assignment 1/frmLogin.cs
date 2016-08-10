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

namespace Assignment_1
{
    public partial class frmLogin : Form 
    {
        public frmLogin()
        {
            InitializeComponent();
        }
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validLogin = checkLogin(txtUsername.Text,txtPassword.Text) ;
           if (validLogin== true)
	{
        frmSchedule frmSchedule = new frmSchedule();
        frmLogin frmLog = new frmLogin();
        frmLog.Hide();
        frmSchedule.Show(); 
	}
           else
           {
               MessageBox.Show("Username or password is incorrect");
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
                    username = temp[0];
                    password = temp[1];
                    if ((user.Equals(username))&&(pass.Equals(password)))
	                    {
	                    isFound = true;
	                    }
                    
                }
                sr.Close();
            }
            catch (Exception )
            {
                
                 return false;
            }
            return isFound;
           
        }

    }
}