

using MemberApi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;


namespace MyWebAPI.Controllers
{
    public class MemberController : Controller
    {
        // GET: api/values
        [HttpPost ]
      [Route ("AddMember")]
        public Members AddMember()
        {
            var context = new MemberDb();

                var std = new Members()
                {
                    Name = "Bill",
                    Age =   1
                };

            context.Members.Add(std);
            context.SaveChanges();

            return std;
        
        }
        

        // GET: api/values/5
       /* public string Get(int id)
        {
            return "value";
        }

        // POST: api/values
        /*public void Post([FromBody] string value)
        {
        }

        // PUT: api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }*/
    }
}