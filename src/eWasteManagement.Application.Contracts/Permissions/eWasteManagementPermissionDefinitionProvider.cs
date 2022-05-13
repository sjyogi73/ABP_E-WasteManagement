using eWasteManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace eWasteManagement.Permissions;

public class eWasteManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(eWasteManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(eWasteManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<eWasteManagementResource>(name);
    }
}
