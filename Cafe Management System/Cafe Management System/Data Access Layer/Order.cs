using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Data_Access_Layer
{
    class Order
    {
        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public double Price { get; set; }
        public int CafeID { get; set; }
    }
}
