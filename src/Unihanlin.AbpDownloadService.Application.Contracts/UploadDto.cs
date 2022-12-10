using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Content;

namespace Unihanlin.AbpDownloadService
{
    public class UploadDto
    {
        public string Text { get; set; }

        public int Timestamp { get; set; }

        [Required]
        public IRemoteStreamContent SingleFile { get; set; }

        public IList<IRemoteStreamContent> Files { get; set; }
    }
}