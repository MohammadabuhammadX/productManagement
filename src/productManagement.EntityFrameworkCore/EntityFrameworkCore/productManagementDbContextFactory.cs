using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace productManagement.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class productManagementDbContextFactory : IDesignTimeDbContextFactory<productManagementDbContext>
{
    public productManagementDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        productManagementEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<productManagementDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new productManagementDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../productManagement.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
