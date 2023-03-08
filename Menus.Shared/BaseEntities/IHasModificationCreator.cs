using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Shared.BaseEntities
{

    public interface IHasModificationCreator
    {
        /// <summary>
        /// 最后的更新时间
        /// </summary>
        DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后的更新人
        /// </summary>
        Guid? LastModifierId { get; set; }
    }
}
