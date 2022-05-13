using eWasteManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace eWasteManagement;

[DependsOn(
    typeof(eWasteManagementEntityFrameworkCoreTestModule)
    )]
public class eWasteManagementDomainTestModule : AbpModule
{

}
