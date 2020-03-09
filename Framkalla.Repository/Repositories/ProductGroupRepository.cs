using Framkalla.Contracts;
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
    public class ProductGroupRepository : RepositoryBase<ProductGroup>, IProductGroupRepository
    {
        public ProductGroupRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IQueryable<ProductGroup> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<ProductGroup>().Include(w => w.WorkFlow);
        }
    }
}
