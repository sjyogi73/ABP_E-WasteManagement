namespace eWasteManagement.Permissions;

public static class eWasteManagementPermissions
{
    public const string GroupName = "eWasteManagement";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class userDetail
        {
            public const string Default = GroupName + ".userDetail";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
}
