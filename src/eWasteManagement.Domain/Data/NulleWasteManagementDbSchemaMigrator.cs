using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace eWasteManagement.Data;

/* This is used if database provider does't define
 * IeWasteManagementDbSchemaMigrator implementation.
 */
public class NulleWasteManagementDbSchemaMigrator : IeWasteManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
