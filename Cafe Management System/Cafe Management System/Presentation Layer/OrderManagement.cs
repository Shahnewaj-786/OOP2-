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
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            orderListDataGridView.DataSource = orderDataAccess.GetAllOrders();
            orderDataAccess = new OrderDataAccess();
            addOrderComboBox.DataSource = orderDataAccess.GetAllCafeNames();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {

        }

        private void OrderManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void UpdateOrderList()
        {
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            orderListDataGridView.DataSource = orderDataAccess.GetAllOrders();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            int cafeId = orderDataAccess.GetCafeIDByName(addOrderComboBox.Text);
            orderDataAccess = new OrderDataAccess();
            if (orderDataAccess.AddNewOrder(addOrderNameTextBox.Text, Convert.ToDouble(addOrderPriceTextBox.Text), cafeId))
            {
                MessageBox.Show("Order Added");
                UpdateOrderList();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            OrderDataAccess orderDataAccess = new OrderDataAccess();
            Order order = orderDataAccess.GetOrderById(Convert.ToInt32(deleteOrderIdTextBox.Text));
            if (order == null)
            {
                MessageBox.Show("Order Not Found");
            }
            else
            {
                orderDataAccess = new OrderDataAccess();
                if (orderDataAccess.DeleteOrder(order.OrderID))
                {
                   MessageBox.Show("Order Deleted");
                   UpdateOrderList();
                }
                else
                {
                   MessageBox.Show("Something Went Wrong");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
