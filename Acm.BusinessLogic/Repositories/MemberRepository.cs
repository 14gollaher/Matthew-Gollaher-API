using System;
using System.Collections.Generic;
using System.Linq;

namespace Acm.BusinessLogic
{
    public class MemberRepository : IMemberRepository
    {
        private AcmContext _context;

        public MemberRepository(AcmContext context)
        {
            _context = context;
        }

        public void DeleteMember(int memberId)
        {
            Member oldMember = _context.Members.FirstOrDefault(m => m.Id == memberId);
            _context.Members.Remove(oldMember);
        }

        public void EditMember(Member member)
        {
            throw new NotImplementedException();
        }

        public Member GetMember(int memberId)
        {
            return _context.Members.FirstOrDefault(m => m.Id == memberId);
        }

        public List<Member> GetMembers()
        {
            return _context.Members.ToList();
        }

        public void InsertMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }
    }
}
