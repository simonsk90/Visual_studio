using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Activity
    {
        public int ID { get; set; }
        public String title { get; set; }
        public String tags { get; set; }
        public String description { get; set; }

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

        public Activity(String title, String description, String tags)
        {
            this.title = title;
            this.description = description;
            this.tags = tags;
        }
    }
}
