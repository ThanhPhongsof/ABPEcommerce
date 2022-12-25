using System;
using Volo.Abp.Domain.Entities;

namespace ABPEcommerce.Domain.Products
{
    public class ProductAttributeDateTime : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime Value { get; set; }
    }
}