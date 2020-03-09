﻿using Framkalla.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framkalla.Contracts.Repositories
{
    public interface IInventoryHistoryRepository : IRepositoryBase<InventoryHistory>
    {
        IQueryable<InventoryHistory> GetAllWithDetails();
    }
}
