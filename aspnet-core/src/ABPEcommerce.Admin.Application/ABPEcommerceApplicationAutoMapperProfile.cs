using ABPEcommerce.Admin.ProductCategories;
using ABPEcommerce.Admin.Products;
using ABPEcommerce.ProductCategories;
using ABPEcommerce.Products;
using AutoMapper;

namespace ABPEcommerce.Admin;

public class ABPEcommerceApplicationAutoMapperProfile : Profile
{
    public ABPEcommerceApplicationAutoMapperProfile()
    {
        // ProductCategory
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        // Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, Product>();
    }
}
