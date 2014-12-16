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
    public class UserController : ApiController
    {
        DBUser dbu = new DBUser();  

        // GET api/User/get/<username>/<password>
        public User Get(String username, String password)
        {
            User u = dbu.getUserByName(username, password);
            return u;
        }
    }
}