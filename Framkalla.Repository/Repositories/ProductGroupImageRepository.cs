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
    public class ProductGroupImageRepository : RepositoryBase<ProductGroupImage>, IProductGroupImageRepository
    {
        public ProductGroupImageRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<ProductGroupImage> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<ProductGroupImage>().Include(p => p.ProductGroup);
        }
    }
}
