using Volo.Abp.Modularity;

namespace productManagement;

public abstract class productManagementApplicationTestBase<TStartupModule> : productManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
