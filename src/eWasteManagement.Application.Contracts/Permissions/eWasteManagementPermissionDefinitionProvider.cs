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

            var userDetailPermission = myGroup.AddPermission(eWasteManagementPermissions.userDetail.Default, L("Permission:userDetail"));
            userDetailPermission.AddChild(eWasteManagementPermissions.userDetail.Create, L("Permission:Create"));
            userDetailPermission.AddChild(eWasteManagementPermissions.userDetail.Update, L("Permission:Update"));
            userDetailPermission.AddChild(eWasteManagementPermissions.userDetail.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<eWasteManagementResource>(name);
    }
}
