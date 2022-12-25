﻿using System;
using Volo.Abp.Domain.Entities;

namespace ABPEcommerce.Promotions
{
    public class PromotionProduct : Entity<Guid>
    {
        public Guid ProductId { get; set; }
        public Guid PromotionId { get; set; }
    }
}