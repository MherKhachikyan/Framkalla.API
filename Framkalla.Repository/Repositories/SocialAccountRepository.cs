using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framkalla.Repository.Models
{
    public class SocialAccountRepository : RepositoryBase<SocialAccount> , ISocialAccountRepository
    {
        public SocialAccountRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<SocialAccount> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<SocialAccount>().Include(u => u.User).Include(s => s.SocialAccountType);
        }
    }
}
