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
    public class ProductTypeBackgroundImageRepository : RepositoryBase<ProductTypeBackgroundImage> , IProductTypeBackgroundImageRepository
    {
        public ProductTypeBackgroundImageRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<ProductTypeBackgroundImage> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<ProductTypeBackgroundImage>().Include(p => p.ProductType);
        }
    }
}
