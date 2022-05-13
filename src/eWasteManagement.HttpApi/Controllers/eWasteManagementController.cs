using eWasteManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace eWasteManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class eWasteManagementController : AbpControllerBase
{
    protected eWasteManagementController()
    {
        LocalizationResource = typeof(eWasteManagementResource);
    }
}
