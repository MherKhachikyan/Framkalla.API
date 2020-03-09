using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;

namespace Framkalla.Repository.Models
{
    public class FreightRuleRepository : RepositoryBase<FreightRule>, IFreightRuleRepository
    {
        public FreightRuleRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
