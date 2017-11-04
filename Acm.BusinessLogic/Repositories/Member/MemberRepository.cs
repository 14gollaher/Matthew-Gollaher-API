﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Acm.BusinessLogic
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AcmContext _context;

        private readonly AcmConfiguration _configuration;

        public MemberRepository(AcmContext context, AcmConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public void DeleteMember(int memberId)
        {
            Member oldMember = _context.Members.FirstOrDefault(m => m.Id == memberId);
            _context.Members.Remove(oldMember);
            _context.SaveChanges();
        }

        public void EditMember(Member member)
        {
            _context.Members.Add(member);
            _context.Entry(member).State = EntityState.Modified;
            _context.SaveChanges();
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
