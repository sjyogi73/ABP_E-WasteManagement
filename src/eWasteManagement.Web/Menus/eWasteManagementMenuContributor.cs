using System.Threading.Tasks;
using eWasteManagement.Permissions;
using eWasteManagement.Localization;
using eWasteManagement.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace eWasteManagement.Web.Menus;

public class eWasteManagementMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<eWasteManagementResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                eWasteManagementMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
            if (await context.IsGrantedAsync(eWasteManagementPermissions.userDetail.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        eWasteManagementMenus.userDetail,
                        l["UserDetails"],
                        url:"/UserDetail/userDetail",
                        icon: "fas fa-users")
                );
            }
    }
}
