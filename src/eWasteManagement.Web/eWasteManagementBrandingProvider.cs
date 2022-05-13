using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace eWasteManagement.Web;

[Dependency(ReplaceServices = true)]
public class eWasteManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "eWasteManagement";
}
