

using MemberApi;
using MemberApi.Repository;
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
        IMemberRepository _memberdb ;
        public MemberController(IMemberRepository memberdb)
        {
            _memberdb = memberdb;
        }

        // POST: api/values
        [HttpPost]
        [Route("member")]
        public IActionResult AddMember([FromBody] Members member)
        {

            _memberdb.AddMember(member);

            return Ok(member);

        }
        // PUT: api/values/5
        [HttpPut]
        [Route("member/{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Members member)
        {
            
            _memberdb.UpdateMember(id,member);

            return Ok();

        }
        // DELETE: api/values/5
        [HttpDelete]
        [Route("member/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            
            
            _memberdb.Removed(id);
            
            return Ok();
        }

        // GET: api/values
        [HttpGet]
        [Route("member")]
        public async Task<IActionResult> Get()
        {


            var member =await _memberdb.GetAllMembers();
            
            return Ok (member);
        }

        [HttpPut]
        [Route("member/{id}/age")]
        public IActionResult UpdateAge([FromRoute] int id)
        {

            _memberdb.IncrementAge(id);

            return Ok();

        }
    }

}