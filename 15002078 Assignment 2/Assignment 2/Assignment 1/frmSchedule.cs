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
using System.Windows;
using System.Windows.Input;

using System.Data.SqlClient;

namespace Assignment_3
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string fileEntry;
            string firstname, surname, phoneNum;
            firstname = txtFirstname.Text;
            surname = txtSurname.Text;
            phoneNum = txtPhoneNum.Text;
            fileEntry = firstname + "," + surname + "," + phoneNum;
            try
            {
                StreamWriter toFile = new StreamWriter(@"Patient.txt", true); // appends to file
                toFile.WriteLine(fileEntry);
                toFile.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            string searchVal;
            int selectedItem = cmbSearchCrit.SelectedIndex;
            var line = "";

            try
            {
                searchVal = txtSearchVal.Text;
                StreamReader sr = new StreamReader(@"Patient.txt"); //literal string
                while (((line = sr.ReadLine()) != null))
                {
                    dynamic[] temp = line.Split(',');
                    if (searchVal.Equals(temp[selectedItem])) // searches for matching value
                    {
                        lbxResults.Items.Add(line);
                    }

                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string login = "";
            string username="";
            string password="";
            var line = "";

            try
           {

                StreamReader sr = new StreamReader(@"Login.txt"); //literal string
                while (((line = sr.ReadLine()) != null))
                {if ((line!= null)&&(line.Equals("")!= true))
                {
                    dynamic[] temp = line.Split(',');
                    
                    
                        username = temp[0];
                        password = temp[1];   
                    }
                   if ((txtUser.Text.Equals(username)) && (txtCurrentPass.Text.Equals(password)))
                    {
                        password = txtNewPass.Text;  // replace old password with new one
                        MessageBox.Show("password changed successfully");
                    }
                    login = login + '.' + username + "," + password;

                }
                dynamic[] arrLoginDet = login.Split('.');
                sr.Close();
                StreamWriter toFile = new StreamWriter(@"Login.txt");
                for (int i = 0; i < arrLoginDet.Length-1; i++)
                {
                    toFile.WriteLine(arrLoginDet[i]);
                }

                toFile.Close();
          }
            catch (Exception exc)
         {
               MessageBox.Show(exc.Message);

            }
        }

        private void btnOpenRep_Click(object sender, EventArgs e)
        {
            
            try
            {

            string report = "First name \t Surname \t Phone number";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string line;
            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();

            System.IO.Stream fileStream = openFileDialog1.OpenFile();

            using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            {

                while (((line = reader.ReadLine()) != null))
                {
                    dynamic[] temp = line.Split(',');
                    report = report + "\n" + temp[0] + "\t" + temp[1] + "\t" + temp[2];
                }
                reader.Close();

            }
            fileStream.Close();
            MessageBox.Show(report);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private void btnGenRep_Click(object sender, EventArgs e)
        {
             try
            {
            string line;
            string report = "Firstname \t\tSurname \t\tPhone number";
            StreamReader reader = new StreamReader(@"Patient.txt"); //literal string
            while (((line = reader.ReadLine()) != null))
            {
                dynamic[] temp = line.Split(',');
                report = report + "\n" + temp[0] + "\t" + temp[1] + "\t" + temp[2];
            }
            reader.Close();
            MessageBox.Show(report);
            }
             catch (Exception exc)
             {
                 MessageBox.Show(exc.Message);

             }
        }

        private void btnSaveRep_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                StreamReader reader = new StreamReader(@"Patient.txt"); //literal string
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    {
                        sw.WriteLine("First name \t Surname \t Phone number");
                        while (((line = reader.ReadLine()) != null))
                        {
                            dynamic[] temp = line.Split(',');
                            sw.WriteLine(temp[0] + "\t" + temp[1] + "\t" + temp[2]);
                        }

                    }
                }



            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        private void cmbSearchCrit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPPOINTMENTSDataSet.APPOINTMENT' table. You can move, or remove it, as needed.
            this.aPPOINTMENTTableAdapter.Fill(this.aPPOINTMENTSDataSet.APPOINTMENT);


           // this.reportViewer1.RefreshReport();
          //  this.reportViewer1.RefreshReport();
         
        }

        private void tbpAddAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
              /*  string A_ID;
                string A_IsAv;
                string A_Time;
                string P_Name;
                string P_Surname;
                string P_Phone; */

                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();
                objDBConnect.sqlCmd = new SqlCommand("IF NOT EXISTS(SELECT * FROM APPOINTMENT WHERE APP_ID = @AP_ID) BEGIN INSERT INTO Employee VALUES (@AP_ID, @APP_IS_AVAIL, @TIMESLOT, @PATIENT_NAME, @PATIENT_SURNAME, @PATIENT_PHONENUM, @DATE)", objDBConnect.sqlConn);
                        
              //  objDBConnect.sqlCmd = new SqlCommand("UPDATE APPOINTMENT VALUES (@TIMESLOT, @PATIENT_NAME, @PATIENT_SURNAME, @PATIENT_PHONENUM )", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@AP_ID", txtAddID.Text);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@APP_IS_AVAIL", txtAddAvail.Text);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@TIMESLOT", txtAddTime);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@DATE", txtAddDate);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_NAME", txtAddName.Text);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_SURNAME", txtAddSurname.Text);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_PHONENUM", txtAddPhonenum.Text);

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESSFULLY ADDED");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
            }
                catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect objDBConnect = new DBConnect();

                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("DELETE * FROM APPOINTMENT WHERE APP_ID = @AP_ID ", objDBConnect.sqlConn);

              
                objDBConnect.sqlCmd.Parameters.AddWithValue("@AP_ID", txtDelAppID.Text);


                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("SUCCESSFULLY REMOVED");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBConnect objDBConnect = new DBConnect();

            objDBConnect.OpenConnection();

            
            objDBConnect.sqlCmd = new SqlCommand("SELECT * FROM APPOINTMENT WHERE APP_ID = @AP_ID ", objDBConnect.sqlConn);
          
            //  objDBConnect.sqlCmd = new SqlCommand("UPDATE APPOINTMENT VALUES (@TIMESLOT, @PATIENT_NAME, @PATIENT_SURNAME, @PATIENT_PHONENUM )", objDBConnect.sqlConn);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@AP_ID", txtAddID.Text);
          lblDelID.Text = objDBConnect.sqlDR["APP_ID"].ToString();
          lblDelAvail.Text = objDBConnect.sqlDR["APP_IS_AVAILABLE"].ToString();
          lblDelTime.Text = objDBConnect.sqlDR["APP_DATE"].ToString();
          lblDelName.Text = objDBConnect.sqlDR["PATIENT_NAME"].ToString();
          lblDelSur.Text = objDBConnect.sqlDR["PATIENT_SURNAME"].ToString();
          lblDelPhone.Text = objDBConnect.sqlDR["PATIENT_PHONENUM"].ToString();
          objDBConnect.sqlDR.Close();
          objDBConnect.sqlConn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnect objDBConnect = new DBConnect();

            objDBConnect.OpenConnection();


            objDBConnect.sqlCmd = new SqlCommand("SELECT * FROM APPOINTMENT WHERE APP_ID = @AP_ID ", objDBConnect.sqlConn);
     
            objDBConnect.sqlCmd.Parameters.AddWithValue("@AP_ID", txtEDID.Text);
            objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
           
            txtEDAvail.Text = objDBConnect.sqlDR["APP_IS_AVAILABLE"].ToString();
            txtEDDate.Text = objDBConnect.sqlDR["APP_DATE"].ToString();
            txtEDName.Text = objDBConnect.sqlDR["PATIENT_NAME"].ToString();
            txtEDSur.Text = objDBConnect.sqlDR["PATIENT_SURNAME"].ToString();
            txtEDPhone.Text = objDBConnect.sqlDR["PATIENT_PHONENUM"].ToString();

            objDBConnect.sqlDR.Close();
            objDBConnect.sqlConn.Close();
        }

        private void btnEDUpdate_Click(object sender, EventArgs e)
        {
            DBConnect objDBConnect = new DBConnect();

            objDBConnect.OpenConnection();

            objDBConnect.sqlCmd = new SqlCommand("UPDATE APPOINTMENT SET (APP_IS_AVAILABLE = @APP_IS_AVAIL, APP_TIMESLOT = @TIMESLOT , PATIENT_NAME = @PATIENT_NAME, PATIENT_SURNAME= @PATIENT_SURNAME, PATIENT_PHONENUM = @PATIENT_PHONENUM, APP_DATE = @DATE) WHERE APP_ID = @AP_ID", objDBConnect.sqlConn);
            
            objDBConnect.sqlCmd.Parameters.AddWithValue("@AP_ID", txtEDID.Text);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@APP_IS_AVAIL", txtEDAvail.Text);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@TIMESLOT", txtEDTime.Text);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@DATE", txtEDDate.Text);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_NAME", txtEDName.Text);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_SURNAME", txtEDSur.Text);
            objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_PHONENUM", txtEDPhone.Text);

            objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
            objDBConnect.sqlDR.Close();
            objDBConnect.sqlConn.Close();
        }

        private void btnDataSearch_Click(object sender, EventArgs e)
        {
            DBConnect objDBConnect = new DBConnect();

            objDBConnect.OpenConnection();


            objDBConnect.sqlDA =new SqlDataAdapter("SELECT * FROM APPOINTMENT WHERE (APP_ID = @AP_ID ) AND (APP_IS_AVAILABLE = @APP_IS_AVAIL) AND (APP_TIMESLOT = @TIMESLOT) AND (PATIENT_NAME = @PATIENT_NAME) AND (PATIENT_SURNAME= @PATIENT_SURNAME) AND (PATIENT_PHONENUM = @PATIENT_PHONENUM) AND (APP_DATE = @DATE) ", objDBConnect.sqlConn);

            if (txtSrID.Equals(""))
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@AP_ID", "*");
            }
            else
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@AP_ID", txtSrID.Text);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////

            if (txtSrAvail.Equals(""))
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@APP_IS_AVAIL", "*");
            }
            else
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@APP_IS_AVAIL", txtSrAvail.Text);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (txtSrTime.Equals(""))
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@TIMESLOT", "*");
            }
            else
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@TIMESLOT", txtEDAvail.Text);
            }
            //////////////////////////////////////////////////////////////////////////////////////////////

            if (txtSrDate.Equals(""))
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@DATE", "*");
            }
            else
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@DATE", txtSrDate.Text);
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
    
            if (txtSrName.Equals(""))
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_NAME", "*");
            }
            else
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_NAME", txtSrName.Text);
            }
            ///////////////////////////////////////////////////////////////////////////////////////
 
            if (txtSrSur.Equals(""))
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_SURNAME", "*");
            }
            else
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_SURNAME", txtSrSur.Text);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////


            if (txtSrPhone.Equals(""))
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_PHONENUM", "*");
            }
            else
            {
                objDBConnect.sqlCmd.Parameters.AddWithValue("@PATIENT_PHONENUM", txtEDAvail.Text);
            }

         
            DataSet ds = new DataSet();
            objDBConnect.sqlDA.Fill(ds);

          dtgSearch.DataSource = ds.Tables[0];
            }

        private void tbpEditAppointment_Click(object sender, EventArgs e)
        {

        }

        }

        
    }
