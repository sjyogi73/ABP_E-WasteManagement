using eWasteManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace eWasteManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(eWasteManagementEntityFrameworkCoreModule),
    typeof(eWasteManagementApplicationContractsModule)
    )]
public class eWasteManagementDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
