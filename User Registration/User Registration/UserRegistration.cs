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
    public partial class UserRegistration : Form
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
            else if (dateOfBirthDatePicker.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("Provide valid date!");
            }
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
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2"].ConnectionString);
                    connection.Open();
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

                    string sql = "INSERT INTO Users(Name,Username,Email,Password,DateOfBirth,Gender,BloodGroup) VALUES('"+user.Name+"','"+user.Username+"','"+user.Email+"','"+user.Password+"','"+user.DateOfBirth+"','"+user.Gender+"','"+user.BloodGroup+"')";
                    SqlCommand command = new SqlCommand(sql, connection);
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result > 0)
                    {
                        MessageBox.Show("User Added");
                        Userlist userlist = new Userlist();
                        userlist.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
     
                }
            }
        }
    }
}
