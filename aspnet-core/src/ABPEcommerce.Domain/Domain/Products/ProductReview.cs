using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABPEcommerce.Products
{
    public class ProductReview : CreationAuditedEntity<Guid>
    {
        public Guid ProductId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
        public string Content { get; set; }
    }
}