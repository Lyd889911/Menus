using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Shared.BaseEntities
{
    public interface IHasDeleteCreator
    {
        /// <summary>
        /// 删除人Id
        /// </summary>
        Guid? DeleteCreatorId { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        DateTime? DeleteTime { get; set; }
    }
}
