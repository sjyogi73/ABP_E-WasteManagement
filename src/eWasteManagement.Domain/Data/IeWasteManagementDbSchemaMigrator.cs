using System.Threading.Tasks;

namespace eWasteManagement.Data;

public interface IeWasteManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
