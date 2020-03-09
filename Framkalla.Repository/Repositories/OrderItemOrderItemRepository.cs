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
    public class OrderItemOrderItemRepository : RepositoryBase<OrderItemOrderItem>, IOrderItemOrderItemRepository
    {
        public OrderItemOrderItemRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<OrderItemOrderItem> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<OrderItemOrderItem>().Include(o => o.OrderItem);
        }
    }
}
