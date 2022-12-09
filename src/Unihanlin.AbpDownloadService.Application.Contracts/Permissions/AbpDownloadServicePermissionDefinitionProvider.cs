using Unihanlin.AbpDownloadService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Unihanlin.AbpDownloadService.Permissions;

public class AbpDownloadServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpDownloadServicePermissions.GroupName, L("Permission:AbpDownloadService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpDownloadServiceResource>(name);
    }
}
