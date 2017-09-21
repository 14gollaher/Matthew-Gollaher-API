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
            throw new NotImplementedException();
        }

        public void EditMember(Member member)
        {
            throw new NotImplementedException();
        }

        public Member GetMember(int memberId)
        {
            throw new NotImplementedException();
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
