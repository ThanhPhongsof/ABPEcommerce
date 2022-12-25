using System;
using Volo.Abp.Domain.Entities;

namespace ABPEcommerce.Products
{
    public class ProductTag : Entity
    {
        public Guid TagId { get; set; }
        public Guid ProductId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { ProductId, TagId };
        }
    }
}