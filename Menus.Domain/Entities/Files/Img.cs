using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Files
{
    /// <summary>
    /// 图片
    /// </summary>
    public class Img:AggregateRoot
    {
        public long FileSizeByte { get; set; }
        public string? FileName { get; set; }
        public string? Sha256 { get; set; }
        public Uri? Url { get; set; }
        public Uri? BackupUrl { get; set; }

        private Img()
        {

        }
        public Img(long FileSizeByte,string? FileName,string? Sha256,Uri? Url,Uri? BackupUrl,Guid CreatorId)
            :base(CreatorId)
        {
            this.FileSizeByte = FileSizeByte;
            this.Sha256= Sha256;
            this.FileName= FileName;
            this.Url= Url;
            this.BackupUrl= BackupUrl;
        }
    }
}
