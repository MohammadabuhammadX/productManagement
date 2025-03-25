using Volo.Abp.Modularity;

namespace productManagement;

[DependsOn(
    typeof(productManagementDomainModule),
    typeof(productManagementTestBaseModule)
)]
public class productManagementDomainTestModule : AbpModule
{

}
