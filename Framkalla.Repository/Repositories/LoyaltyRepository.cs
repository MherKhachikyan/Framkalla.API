using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framkalla.Repository.Models
{
    public class LoyaltyRepository : RepositoryBase<Loyalty>, ILoyaltyRepository
    {
        public LoyaltyRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
