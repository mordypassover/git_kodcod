using LibreryApi.Repos;
using Microsoft.AspNetCore.Mvc;
using LibreryApi.models;

namespace LibreryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MemberController: ControllerBase   
    {
        IMemberRepo _memberRepo;

        public MemberController(IMemberRepo memberRepo)
        {
            _memberRepo = memberRepo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Member>>> GetAllMembers()
        {
            return  Ok(await _memberRepo.getAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Member?>> GetMember(int id)
        {
            var member = await _memberRepo.getById(id);
            if (member == null) {return NotFound();}
            return Ok(member) ;
        }
        [HttpPost]
        public async Task<Member> MemberAsync(Member member)
        {
            var success = await _memberRepo.addAsync(member);
            return success;
        }

    }
}
