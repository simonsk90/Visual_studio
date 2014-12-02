using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Activity
    {
        private object p1;
        private object p2;
        private object p3;
        private object p4;

        public int ID { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public String tags { get; set; }

        public Activity()
        {

        }

        public Activity(int ID, String title, String description, String tags)
        {
            this.ID = ID;
            this.title = title;
            this.description = description;
            this.tags = tags;
        }

    }
}