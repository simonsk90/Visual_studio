using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Location
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int zipCode { get; set; }
        public string city { get; set; }

        public Location(string name, string address, int zipCode, string city)
        {
            this.name = name;
            this.address = address;
            this.zipCode = zipCode;
            this.city = city;
        }

        public Location()
        {

        }
    }
}
