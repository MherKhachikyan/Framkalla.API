using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framkalla.Repository.Models
{
    public class VoucherRuleRepository : RepositoryBase<VoucherRule> , IVoucherRuleRepository
    {
        public VoucherRuleRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
