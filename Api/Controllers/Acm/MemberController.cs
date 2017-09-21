using Acm.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Acm
{
    [Route("acm/member")]
    public class MemberController : Controller
    {
        private IMemberRepository _memberRepository;

        public MemberController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        [HttpPost("")]
        public IActionResult InsertMember([FromBody] Member member)
        {
            try
            {
                _memberRepository.InsertMember(member);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok();
        }

        [HttpGet("")]
        public IActionResult GetMembers()
        {
            IEnumerable<Member> members;
            try
            {
                members = _memberRepository.GetMembers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(members);
        }

        [HttpGet("{memberId}")]
        public IActionResult GetMember(int memberId)
        {
            Member member;
            try
            {
                member = _memberRepository.GetMember(memberId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok(member);
        }

        [HttpPatch("")]
        public IActionResult EditMember([FromBody] Member member)
        {
            try
            {
                _memberRepository.EditMember(member);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok();
        }

        [HttpDelete("{memberId}")]
        public IActionResult DeleteMember(int memberId)
        {
            try
            {
                _memberRepository.DeleteMember(memberId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500);
            }
            return Ok();
        }
    }
}
