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
    public class UserDeviceRepository : RepositoryBase<UserDevice> , IUserDeviceRepository
    {
        public UserDeviceRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<UserDevice> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<UserDevice>().Include(u => u.User).Include(d => d.Device);
        }
    }
}
