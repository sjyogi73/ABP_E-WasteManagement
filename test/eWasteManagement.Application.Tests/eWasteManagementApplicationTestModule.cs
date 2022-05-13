using Volo.Abp.Modularity;

namespace eWasteManagement;

[DependsOn(
    typeof(eWasteManagementApplicationModule),
    typeof(eWasteManagementDomainTestModule)
    )]
public class eWasteManagementApplicationTestModule : AbpModule
{

}
