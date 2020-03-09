using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framkalla.Contracts.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Framkalla.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public ProductsController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            foreach (var item in _repoWrapper.ProductTypeRepository.GetAll())
            {
                yield return item.Name;
            }
        }
    }
}
