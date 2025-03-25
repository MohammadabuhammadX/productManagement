using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace productManagement.Data;

/* This is used if database provider does't define
 * IproductManagementDbSchemaMigrator implementation.
 */
public class NullproductManagementDbSchemaMigrator : IproductManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
