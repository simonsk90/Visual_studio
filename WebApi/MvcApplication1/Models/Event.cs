using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public class Event
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public Location location { get; set; }
        public String lecturer { get; set; }
        public Activity acti { get; set; }
        private List<User> attendantsList = new List<User>();

        public Event()
        {

        }

        public Event(int ID, DateTime date, Location location, String lecturer, Activity acti)
        {
            this.ID = ID;
            this.date = date;
            this.location = location;
            this.lecturer = lecturer;
            this.acti = acti;
        }

        public Event(DateTime date, Location location, String lecturer, Activity acti)
        {
            this.date = date;
            this.location = location;
            this.lecturer = lecturer;
            this.acti = acti;
        }

        public List<User> getAttendantsList()
        {
            return this.attendantsList;
        }

        public void addAttendant(User u)
        {
            attendantsList.Add(u);
        }

        
    }
}
