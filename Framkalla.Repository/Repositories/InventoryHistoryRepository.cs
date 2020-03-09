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
    public class InventoryHistoryRepository : RepositoryBase<InventoryHistory>, IInventoryHistoryRepository
    {
        public InventoryHistoryRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<InventoryHistory> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<InventoryHistory>().Include(i => i.Inventory);
        }
    }
}
