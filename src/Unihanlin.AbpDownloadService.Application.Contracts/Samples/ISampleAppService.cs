using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Content;

namespace Unihanlin.AbpDownloadService.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();

    Task<IRemoteStreamContent> DownloadAsync(string name);

    Task<IRemoteStreamContent> TransferAsync(UploadDto input);
}
