using Cafe_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Presentation_Layer
{
    public partial class CafeManagement : Form
    {
        public CafeManagement()
        {
            InitializeComponent();
        }

        private void CafeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CafeManagement_Load(object sender, EventArgs e)
        {
            UpdateCafeList();
        }

        void UpdateCafeList()
        {
            CafeDataAccess cafeDataAccess = new CafeDataAccess();
            cafeListDataGridView.DataSource = cafeDataAccess.GetAllCafes();
        }

        private void addCafeButton_Click(object sender, EventArgs e)
        {
            CafeDataAccess cafeDataAccess = new CafeDataAccess();
            if (cafeDataAccess.AddNewCafe(addCafeNameTextBox.Text))
            {
                MessageBox.Show("Cafe Added");
                UpdateCafeList();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void deleteCafeButton_Click(object sender, EventArgs e)
        {
            CafeDataAccess cafeDataAccess = new CafeDataAccess();
            if (cafeDataAccess.DeleteCafe(Convert.ToInt32(deleteCafeIdTextBox.Text)))
            {
                MessageBox.Show("Cafe Deleted");
                UpdateCafeList();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CafeDataAccess cafeDataAccess = new CafeDataAccess();
            string value = cafeDataAccess.GetCafeNameById(Convert.ToInt32(searchCafeIdTextBox.Text));
            if (value == null)
            {
                MessageBox.Show("Cafe Not Found");
            }
            else
            {
                updateCafeNameTextBox.Text = value;
            }
        }

        private void updateCafeButton_Click(object sender, EventArgs e)
        {
            /*CafeDataAccess cafeDataAccess = new CafeDataAccess();
            if (cafeDataAccess.UpdateCafe(Convert.ToInt32(searchCafeIdTextBox.Text), updateCafeNameTextBox.Text))
            {
                MessageBox.Show("Cafe Updated");
                UpdateCafeList();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }*/
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
