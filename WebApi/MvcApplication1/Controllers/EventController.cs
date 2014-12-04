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
    public class EventController : ApiController
    {
        DBEvent dbe = new DBEvent();

        // GET api/<controller>
        public IEnumerable<Event> Get()
        {
            return dbe.getAllEvents();
        }

        // GET api/<controller>/5
        public Event Get(int ID)
        {
            return dbe.getEventByID(ID);
        }

        // POST api/<controller>
        public void Post([FromBody]Event _event)
        {
            dbe.addEvent(_event);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}