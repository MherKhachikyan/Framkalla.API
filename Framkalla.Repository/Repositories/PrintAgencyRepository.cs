using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framkalla.Repository.Models
{
    public class PrintAgencyRepository : RepositoryBase<PrintAgency>, IPrintAgencyRepository
    {
        public PrintAgencyRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
