using MvcApplication1.DB;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class UserAttendantsController : ApiController
    {
        DBAttendants dbatt = new DBAttendants();

        public List<Event> Get(int id)
        {
            return dbatt.getEventsByUser(id);
        }

        // POST api/UserAttendance
        public void Post([FromBody]Attendants a)
        {
            dbatt.addAttendants(a);
        }
    }
}