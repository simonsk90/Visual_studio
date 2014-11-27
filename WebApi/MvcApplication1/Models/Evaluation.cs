using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Evaluation
    {
        public User user { get; set; }
        public Activity activity { get; set; }
        public int rating { get; set; }
        public String note { get; set; }

        public Evaluation()
        {

        }

        public Evaluation(User user, Activity activity, int rating)
        {
            this.user = user;
            this.activity = activity;
            this.rating = rating;
        }

    }
}