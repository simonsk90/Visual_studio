using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public class Location
    {
        public int ID { get; set; }    
        public String name { get; set; }
        public String address { get; set; }
        public int zipcode { get; set; }
        public String city { get; set; }

        public Location()
        {

        }

        public Location(int ID, String name, String address, int zipcode, String city)
        {
            this.ID = ID;
            this.name = name;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
        }

        public Location(String name, String address, int zipcode, String city)
        {

            this.name = name;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
        }
    }
}
