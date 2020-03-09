using Framkalla.Contracts.Repositories;
using Framkalla.Entities;
using Framkalla.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framkalla.Repository.Models
{
    public class ExchangeRateRepository : RepositoryBase<ExchangeRate>, IExchangeRateRepository
    {
        public ExchangeRateRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
