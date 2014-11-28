using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public class Event
    {
        public DateTime time { get; set; }
        public Location location { get; set; }
        public String lecturer { get; set; }
        private List<User> attendanceList;

        public Event()
        {

        }

        public Event(DateTime time, Location location, String lecturer)
        {
            this.time = time;
            this.location = location;
            this.lecturer = lecturer;
        }



    }
}
