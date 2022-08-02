using ZapierDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ZapierDemo.Permissions;

public class ZapierDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ZapierDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ZapierDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ZapierDemoResource>(name);
    }
}
