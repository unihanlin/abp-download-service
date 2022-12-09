namespace Unihanlin.AbpDownloadService;

public static class AbpDownloadServiceDbProperties
{
    public static string DbTablePrefix { get; set; } = "AbpDownloadService";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AbpDownloadService";
}
