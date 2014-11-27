using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public class Attendance
    {
        private List<User> attendanceList;

        public Attendance()
        {
            attendanceList = new List<User>();
        }

        public List<User> getAttendanceList()
        {
            return this.attendanceList;
        }

        public void addAttendance(User user)
        {
            this.attendanceList.Add(user);
        }


    }
}
