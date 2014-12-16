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
    public class EventAttendantsController : ApiController
    {
        DBAttendants dbatt = new DBAttendants();

        public List<User> Get(int id)
        {
            return dbatt.getAttendantsByEvent(id);
        }
    }
}