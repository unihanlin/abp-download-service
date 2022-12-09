using Volo.Abp.Reflection;

namespace Unihanlin.AbpDownloadService.Permissions;

public class AbpDownloadServicePermissions
{
    public const string GroupName = "AbpDownloadService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AbpDownloadServicePermissions));
    }
}
