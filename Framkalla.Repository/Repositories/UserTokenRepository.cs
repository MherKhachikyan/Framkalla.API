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
    public class UserTokenRepository : RepositoryBase<UserToken> , IUserTokenRepository
    {
        public UserTokenRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<UserToken> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<UserToken>().Include(u => u.User);
        }
    }
}
