using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Metrodev.ABMExample.Authorization;
using Metrodev.ABMExample.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrodev.ABMExample.Products
{
    [AbpAuthorize]
    public class ProductsAppService : AsyncCrudAppService<Product, ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}
