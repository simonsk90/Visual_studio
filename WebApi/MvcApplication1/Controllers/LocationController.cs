using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.DB;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class LocationController : ApiController
    {
        DBLocation dbl = new DBLocation();
        // GET api/Location/
        public Location Get(int ID)
        {
            return dbl.getLocationByID(ID);
        }


        // POST api/<controller>
        public void Post([FromBody]Location location)
        {
            dbl.addLocation(location);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Location location)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}