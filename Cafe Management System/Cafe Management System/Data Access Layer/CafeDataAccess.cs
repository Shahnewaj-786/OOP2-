using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Data_Access_Layer
{
    class CafeDataAccess:DataAccess
    {
        public List<Cafe> GetAllCafes()
        {
            string sql = "SELECT * FROM Cafes";
            SqlDataReader reader = this.GetData(sql);
            List<Cafe> cafes = new List<Cafe>();
            while (reader.Read())
            {
                Cafe cafe = new Cafe();
                cafe.CafeId = (int)reader["CafeID"];
                cafe.CafeName = reader["CafeName"].ToString();
                cafes.Add(cafe);
            }
            return cafes;
        }

        public bool AddNewCafe(string cafeName)
        {
            string sql = "INSERT INTO Cafes(CafeName) VALUES('" + cafeName + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteCafe(int cafeId)
        {
            string sql = "DELETE FROM Cafes WHERE CafeID=" + cafeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public string GetCafeNameById(int cafeId)
        {
            string sql = "SELECT * FROM Cafes WHERE CafeId=" + cafeId;
            SqlDataReader reader = this.GetData(sql);
            List<Cafe> cafes = new List<Cafe>();
            if (reader.Read())
            {
                return reader["CafeName"].ToString();
            }
            return null;
        }

        public string UpdateCafe(int cafeId, string cafeName)
        {
            string sql = "UPDATE Cafes SET CafeName='" + cafeName + "' WHERE CafeID=" + cafeId;
            SqlDataReader reader = this.GetData(sql);
            List<Cafe> cafes = new List<Cafe>();
            if (reader.Read())
            {
                return reader["CafeName"].ToString();
            }
            return null;
        }
    }
}
