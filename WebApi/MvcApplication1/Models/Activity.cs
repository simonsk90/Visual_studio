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
        public Event _event { get; set; }

        public Activity()
        {

        }

        public Activity(int ID, String title, String description, Event _event)
        {
            this.ID = ID;
            this.title = title;
            this.description = description;
            this._event = _event;
        }

    }
}