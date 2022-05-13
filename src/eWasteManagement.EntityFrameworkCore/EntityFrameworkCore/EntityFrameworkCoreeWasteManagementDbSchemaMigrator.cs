using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using eWasteManagement.Data;
using Volo.Abp.DependencyInjection;

namespace eWasteManagement.EntityFrameworkCore;

public class EntityFrameworkCoreeWasteManagementDbSchemaMigrator
    : IeWasteManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreeWasteManagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the eWasteManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<eWasteManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
