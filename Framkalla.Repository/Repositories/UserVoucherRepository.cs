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
    public class UserVoucherRepository : RepositoryBase<UserVoucher> , IUserVoucherRepository
    {
        public UserVoucherRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<UserVoucher> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<UserVoucher>().Include(u => u.User);
        }
    }
}
