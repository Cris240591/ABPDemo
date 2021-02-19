using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Metrodev.ABMExample.Authorization.Users;
using System;

namespace Metrodev.ABMExample.Products
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
    }
}
