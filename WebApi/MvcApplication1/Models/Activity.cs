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
        public String tags { get; set; }

        public Activity()
        {

        }

        public Activity(int ID, String title, String description, String tags)
        {
            if (ID != 1337)
            {
                this.ID = ID;
            }
            this.title = title;
            this.description = description;
            this.tags = tags;
        }

    }
}