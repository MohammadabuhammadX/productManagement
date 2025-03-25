using Volo.Abp.Modularity;

namespace productManagement;

[DependsOn(
    typeof(productManagementApplicationModule),
    typeof(productManagementDomainTestModule)
)]
public class productManagementApplicationTestModule : AbpModule
{

}
