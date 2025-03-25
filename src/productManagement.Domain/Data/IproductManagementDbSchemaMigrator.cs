using System.Threading.Tasks;

namespace productManagement.Data;

public interface IproductManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
