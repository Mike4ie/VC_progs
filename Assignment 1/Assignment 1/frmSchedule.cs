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

namespace Assignment_1
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
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
                MessageBox.Show("Patient added successfully");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxResults.Items.Clear();

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
                MessageBox.Show("Search complete");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string login = "";
            string username = "";
            string password = "";
            var line = "";

            try
            {

                StreamReader sr = new StreamReader(@"Login.txt"); //literal string
                while (((line = sr.ReadLine()) != null))
                {
                    if ((line != null) && (line.Equals("") != true))
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
                for (int i = 0; i < arrLoginDet.Length - 1; i++)
                {
                    toFile.WriteLine(arrLoginDet[i]);
                }

                toFile.Close();
                MessageBox.Show("Password Reset");
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

        private void btnSaveRep_Click(object sender, EventArgs e) // save dialog
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }


    }
}