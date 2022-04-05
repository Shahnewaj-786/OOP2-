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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manageCafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeManagement cafeManagement = new CafeManagement();
            cafeManagement.Show();
            this.Hide();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement();
            orderManagement.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
