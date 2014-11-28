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
        // GET api/<controller>
        public void Get()
        {
            //Retunere alle events
        }

        // GET api/<controller>/5
        public void Get(int id)
        {
            //retunere alle events ud fra et aktivitetsID
        }

        // POST api/<controller>
        public void Post([FromBody]Event _event)
        {
            //Add ny event i databasen
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Event _event)
        {
            //Update i databasen hvor 
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}