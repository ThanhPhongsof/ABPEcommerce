﻿using System;
using Volo.Abp.Domain.Entities;

namespace ABPEcommerce.Products
{
    public class ProductLink : Entity
    {
        public Guid ProductId { get; set; }
        public string LinkedProductId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { ProductId, LinkedProductId };
        }
    }
}