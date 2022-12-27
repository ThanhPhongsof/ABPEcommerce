using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPEcommerce.Products
{
    public class ProductReviewConfiguration : IEntityTypeConfiguration<ProductReview>
    {
        public void Configure(EntityTypeBuilder<ProductReview> builder)
        {
            builder.ToTable(ABPEcommerceConsts.DbTablePrefix + "ProductReview");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}