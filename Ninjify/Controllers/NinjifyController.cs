using Ninjify.Models;
using Ninjify.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ninjify.Controllers
{
    public class NinjifyController : ApiController
    {

        Algorithm algo = new Algorithm();

        // GET: api/Ninjify
        public NinjifyModel Get()
        {
            string input = System.Web.HttpUtility.ParseQueryString(Request.RequestUri.Query).Get("x");
            string ninjaName = algo.WordToNinja(input);
            NinjifyModel ninja = new NinjifyModel();
            ninja.name = ninjaName;
            return ninja;
        }

        // GET: api/Ninjify/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ninjify
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ninjify/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ninjify/5
        public void Delete(int id)
        {
        }

        List<string> ParseQuery(string query)
        {
            List<string> values = new List<string>();

            string everyValue = query.Substring(2);


            return values;
        }
    }
}
