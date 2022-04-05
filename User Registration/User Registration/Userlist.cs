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
    public partial class Userlist : Form
    {
        public Userlist()
        {
            InitializeComponent();
        }

        private void Userlist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Userlist_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["OOP2"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["Id"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString();
                user.Password = reader["Password"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.BloodGroup = reader["BloodGroup"].ToString();
                users.Add(user);

            }
            userListDataGridView.DataSource = users;
            connection.Close();
        }

        private void userREgistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Show();
            this.Hide();
        }
    }
}
