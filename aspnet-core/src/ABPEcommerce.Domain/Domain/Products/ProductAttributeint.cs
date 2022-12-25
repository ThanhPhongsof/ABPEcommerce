using System;
using Volo.Abp.Domain.Entities;

namespace ABPEcommerce.Domain.Products
{
    public class ProductAttributeint : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public int Value { get; set; }
    }
}