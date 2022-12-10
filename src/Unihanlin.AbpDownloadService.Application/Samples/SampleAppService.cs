using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Content;
using Volo.Abp.IO;

namespace Unihanlin.AbpDownloadService.Samples;

public class SampleAppService : AbpDownloadServiceAppService, ISampleAppService
{
    public Task<SampleDto> GetAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    [Authorize]
    public Task<SampleDto> GetAuthorizedAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    public async Task<IRemoteStreamContent> DownloadAsync(string name)
    {
        var testPath = @"C:\Users\zlchu\Desktop\test";
        var bytes = await FileHelper.ReadAllBytesAsync(Path.Combine(testPath, name));
        return new RemoteStreamContent(new MemoryStream(bytes), name);
    }

    public async Task<IRemoteStreamContent> TransferAsync(UploadDto input)
    {
        var stream = input.SingleFile.GetStream();
        return new RemoteStreamContent(stream, input.SingleFile.FileName, input.SingleFile.ContentType);
    }
}
