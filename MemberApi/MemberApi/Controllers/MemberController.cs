using Member.Data.Interface;
using Member.Data.Model;
using Member.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemberApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMember members = new MembersRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Members>> GetAllMembers()
        {
            return members.GetAllMember();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Members> GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}
