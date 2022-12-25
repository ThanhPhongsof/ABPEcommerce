using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABPEcommerce.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public Guid CategoryId { get; set; }
        public Guid ManufacturerId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public string SKU { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool isActive { get; set; }
        public string SeoMetaDescription { get; set; }
        public string Description { get; set; }
        public string ThumbnailPicture { get; set; }
    }
}