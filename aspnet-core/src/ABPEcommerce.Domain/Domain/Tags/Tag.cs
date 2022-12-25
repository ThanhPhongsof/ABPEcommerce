using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABPEcommerce.Tags
{
    public class Tag : CreationAuditedAggregateRoot<Guid>
    {
        public string Label { get; set; }
        public string Slug { get; set; }
    }
}