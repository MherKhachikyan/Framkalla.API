using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Framkalla.Repository.Models
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Product> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<Product>()
                .Include(p => p.PrintAgency)
                .Include(p => p.ProductType)
                .Include(p => p.PaperFamily);
        }
    }
}
