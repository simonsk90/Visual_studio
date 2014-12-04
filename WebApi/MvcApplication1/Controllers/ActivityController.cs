using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.DB;

namespace MvcApplication1.Controllers
{
    public class ActivityController : ApiController
    {
        DBActivity dba = new DBActivity();  
        // GET api/Activity/
        public Activity Get(int ID)
        {    
            return dba.getActivityByID(ID);
        }

        public List<Activity> Get()
        {
            return dba.getAllActivities();
        }

        // POST api/<controller>
        public void Post([FromBody] Activity activity)
        {
            //add activity til database
            dba.addActivity(activity);
            
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