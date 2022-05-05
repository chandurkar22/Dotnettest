

using MemberApi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;


namespace MyWebAPI.Controllers
{
    [Route("abc")]
    public class MemberController : Controller
    {
        // POST: api/values
        [HttpPost]
        [Route("member")]
        public Members AddMember([FromBody] Members member)
        {
            var context = new MemberDb();

            var std = new Members()
            {
                Name = member.Name,
                Age = member.Age,
            };

            context.Members.Add(std);
            context.SaveChanges();

            return std;

        }
        // PUT: api/values/5
        [HttpPut]
        [Route("member/{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Members member)
        {
            var context = new MemberDb();
            var std = context.Members.Where(x => x.Id == id).FirstOrDefault();
            if(std == null)
            {
                return BadRequest("Id is not Valid .");
            }
            else
            {
                std.Name = member.Name;
                std.Age = member.Age;
            }
            
            context.SaveChanges();

            return Ok(std);

        }
        // DELETE: api/values/5
        [HttpDelete]
        [Route("member/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");

            using (var context = new MemberDb())
            {
                var std = context.Members.Where(x => x.Id == id).FirstOrDefault();  
                context.Members.Remove(std);
                context.SaveChanges();
            }
            return Ok();
        }

        // GET: api/values
        [HttpGet]
        [Route("member")]
        public IActionResult Get()
        {
            
            IList<Members> members = null;
            
            using (var context = new MemberDb())
            {
                members = context.Members.ToList<Members>();
            }
            if (members == null)
            {
                return NotFound();
            }

            return Ok (members);
        }


    }
}



