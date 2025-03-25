using Volo.Abp.Modularity;

namespace productManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class productManagementDomainTestBase<TStartupModule> : productManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
