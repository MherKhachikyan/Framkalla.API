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
    public class ImageInfoRepository : RepositoryBase<ImageInfo>, IImageInfoRepository
    {
        public ImageInfoRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<ImageInfo> GetAllWithDetails()
        {
            return this.RepositoryContext.Set<ImageInfo>().Include(i => i.OrderItemId);
        }
    }
}
