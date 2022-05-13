using eWasteManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace eWasteManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class eWasteManagementPageModel : AbpPageModel
{
    protected eWasteManagementPageModel()
    {
        LocalizationResourceType = typeof(eWasteManagementResource);
    }
}
