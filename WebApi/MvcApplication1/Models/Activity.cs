using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public String title { get; set; }
        public String description { get; set; }

        public Activity()
        {

        }

        public Activity(String title, String description)
        {
            this.ID = ID;
            this.title = title;
            this.description = description;
        }

    }
}