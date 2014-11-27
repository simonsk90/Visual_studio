using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public class User
    {
        public int ID { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
        public String birthday { get; set; }
        public String email { get; set; }

        public User()
        {

        }

        public User(int ID, String fName, String lName, String birthday, String email)
        {
            this.ID = ID;
            this.fName = fName;
            this.lName = lName;
            this.birthday = birthday;
            this.email = email;
        }
    }
}
