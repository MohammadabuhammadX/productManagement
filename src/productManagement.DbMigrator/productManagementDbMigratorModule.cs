using productManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace productManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(productManagementEntityFrameworkCoreModule),
    typeof(productManagementApplicationContractsModule)
)]
public class productManagementDbMigratorModule : AbpModule
{
}
