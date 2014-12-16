using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MvcApplication1.Models
{
    public class User
    {
        public int ID { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
        public DateTime birthday { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public int ranking { get; set; }

        public User()
        {

        }

        public User(int ID, String fName, String lName, DateTime birthday, String email, String password, int ranking)
        {
            this.ID = ID;
            this.fName = fName;
            this.lName = lName;
            this.birthday = birthday;
            this.email = email;
            this.password = password;
            this.ranking = ranking;
        }

        public User(String fName, String lName, DateTime birthday, String email, String password, int ranking)
        {
            this.fName = fName;
            this.lName = lName;
            this.birthday = birthday;
            this.email = email;
            this.password = password;
            this.ranking = ranking;
        }
    }
}
