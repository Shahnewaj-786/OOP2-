using Cafe_Management_System.Data_Access_Layer;
using Cafe_Management_System.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration
{
    public partial class UserRegistration:Form
    {
        private object dateOfBirthDatePicker;

        public UserRegistration()
        {
            InitializeComponent();
            submitButton.Enabled = false;
        }

        private void UserRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void termsCheckBox_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(nametextBox.Text == "")
            {
                MessageBox.Show("Please Provide all Information!");
            }
            else if(usernametextBox.Text == "")
            {
                MessageBox.Show("Please Provide all Information!");
            }
            else if (emailtextBox.Text == "")
            {
                MessageBox.Show("Please Provide all Information!");
            }
            else if (passwordtextBox.Text == "")
            {
                MessageBox.Show("Provide Password!");
            }
            else if (confirmpasstextBox.Text == "")
            {
                MessageBox.Show("Confirm Your Password!");
            }
            /*else if (dateOfBirthDatePicker.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Provide valid date!");
            }*/
            else if ((maleRadioButton.Checked == false) && (femaleRadioButton.Checked == false))
            {
                MessageBox.Show("Please Provide all Information!");
            }
            else if (BloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Please Provide all Information!");
            }
            else
            {
                if(passwordtextBox.Text != confirmpasstextBox.Text)
                {
                    MessageBox.Show("Password does not match");
                }
                else
                {
                    User user = new User();
                    user.Name = nametextBox.Text;
                    user.Username = usernametextBox.Text;
                    user.Email = emailtextBox.Text;
                    user.Password = passwordtextBox.Text;
                    user.DateOfBirth = (string)dateOfBirthDatePicker;
                    if (maleRadioButton.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else
                    {
                        user.Gender = "Female";
                    }
                    user.BloodGroup = BloodGroupComboBox.Text;

                    
                    UserDataAccess userDataAccess = new UserDataAccess();
                    if (userDataAccess.UserRegister(user))
                    {
                        MessageBox.Show("User Registration Complete");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
     
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
