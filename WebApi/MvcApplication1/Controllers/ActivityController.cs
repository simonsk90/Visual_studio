﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ActivityController : ApiController
    {
 
        // GET api/<controller>/5
        public bool Get(int id)
        {
            if (id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }


        public bool Get()
        {
            return true;
        }
    }
}