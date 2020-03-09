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
    public class ProductTypeRepository : RepositoryBase<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IQueryable<ProductType> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<ProductType>().Include(p => p.Group).Include(p => p.ProductImage);
        }
    }
}
