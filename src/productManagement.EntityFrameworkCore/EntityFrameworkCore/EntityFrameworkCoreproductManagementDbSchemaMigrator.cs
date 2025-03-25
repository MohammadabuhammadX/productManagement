using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using productManagement.Data;
using Volo.Abp.DependencyInjection;

namespace productManagement.EntityFrameworkCore;

public class EntityFrameworkCoreproductManagementDbSchemaMigrator
    : IproductManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreproductManagementDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the productManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<productManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
