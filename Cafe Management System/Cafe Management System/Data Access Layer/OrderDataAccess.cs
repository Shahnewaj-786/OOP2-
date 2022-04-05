using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Data_Access_Layer
{
    class OrderDataAccess:DataAccess
    {
        public List<Order> GetAllOrders()
        {
            string sql = "SELECT * FROM Orders";
            List<Order> orders = new List<Order>();
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                Order order = new Order();
                order.OrderID = (int)reader["OrderID"];
                order.OrderName = reader["OrderName"].ToString();
                order.Price = Convert.ToDouble(reader["Price"]);
                order.CafeID = (int)reader["CafeID"];
                orders.Add(order);
            }
            return orders;
        }

        public bool AddNewOrder(string orderName, double price, int cafeId)
        {
            string sql = "INSERT INTO Orders(OrderName,Price,CafeID) VALUES('"+orderName+"',"+price+","+cafeId+")";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteOrder(int orderId)
        {
            string sql = "DELETE FROM Orders WHERE OrderID="+orderId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }


        public bool UpdateOrder(int orderId, string orderName, double price, int cafeId)
        {
            string sql = "UPDATE Orders SET OrderName='"+orderName+"',Price="+price+",CafeID="+cafeId+" WHERE OrderID"+orderId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public List<string> GetAllCafeNames()
        {
            string sql = "SELECT * FROM Cafes";
            List<string> cafeNames = new List<string>();
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                cafeNames.Add(reader["CafeName"].ToString());
            }
            return cafeNames;
        }

        public int GetCafeIDByName(string cafeName)
        {
            string sql = "SELECT * FROM Cafes WHERE CafeName='"+cafeName+"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return (int)reader["CafeID"];
            }
            return -1;
        }

        public Order GetOrderById(int orderId)
        {
            string sql = "SELECT * FROM Orders WHERE OrderID="+orderId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Order order = new Order();
                order.OrderID = (int)reader["OrderID"];
                order.OrderName = reader["OrderName"].ToString();
                order.Price = Convert.ToDouble(reader["Price"]);
                order.CafeID = (int)reader["CafeID"];
                return order;
            }
            return null;
        }
    }
}
