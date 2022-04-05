using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationHasARelation
{
    class Address
    {
        private string road, house, area;

        public Address(string road, string house, string area)
        {
            this.road = road;
            this.house = house;
            this.area = area;
        }
        public string GetAddress()
        {
            return "Address: Road:" +this.road+", House: "+this.house+", Area:" +this.area;
        }
    }
}
