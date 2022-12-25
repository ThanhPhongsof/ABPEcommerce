using System;
using Volo.Abp.Domain.Entities;

namespace ABPEcommerce.Promotions
{
    public class PromotionManufacturer : Entity<Guid>
    {
        public Guid ManufacturerId { get; set; }
        public Guid PromotionId { get; set; }
    }
}