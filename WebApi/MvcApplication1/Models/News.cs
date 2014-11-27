using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class News
    {
        public int ID { get; set; }
        public String name { get; set; }
        public String Description { get; set; }

        public News()
        {

        }

        public News(int ID, String name, String desc)
        {
            this.ID = ID;
            this.name = name;
            this.Description = desc;
        }

    }
}