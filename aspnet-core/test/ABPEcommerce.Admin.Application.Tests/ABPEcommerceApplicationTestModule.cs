using Volo.Abp.Modularity;

namespace ABPEcommerce.Admin;

[DependsOn(
    typeof(ABPEcommerceApplicationModule),
    typeof(ABPEcommerceDomainTestModule)
    )]
public class ABPEcommerceApplicationTestModule : AbpModule
{

}
