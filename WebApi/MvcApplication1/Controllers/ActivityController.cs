﻿using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ActivityController : ApiController
    {

        // GET api/Activity/
        public void Get()
        {
            //Retuner alle aktiviteter
        }

        // POST api/<controller>
        public void Post([FromBody] Activity activity)
        {
            //add activity til database
            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Activity activity)
        {
            //Update i database hvor id er = ID
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            //Slet activity hvor id = id
        }

    }
}