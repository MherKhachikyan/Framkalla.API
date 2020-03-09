using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framkalla.Repository.Models
{
    public class PaperFamilyRepository : RepositoryBase<PaperFamily>, IPaperFamilyRepository
    {
        public PaperFamilyRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
