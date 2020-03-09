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
    public class VoucherRepository : RepositoryBase<Voucher> , IVoucherRepository
    {
        public VoucherRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Voucher> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<Voucher>().Include(v => v.VoucherTypes);
        }
    }
}
