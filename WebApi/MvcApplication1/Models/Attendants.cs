using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Attendants
    {
        public int eventID { get; set; }
        public int userID { get; set; }

        public Attendants(int eventID, int userID)
        {
            this.eventID = eventID;
            this.userID = userID;
        }
    }
}