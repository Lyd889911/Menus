using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Raws
{
    /// <summary>
    /// 原料
    /// </summary>
    public class Raw:AggregateRoot
    {
        /// <summary>
        /// 原料，食材名字
        /// </summary>
        public string RawName { get; set; }

        /// <summary>价格</summary>
        public Price Price { get; set; }
        public Raw(string rawName,Price price,Guid CreatorId):base(CreatorId)
        {
            this.RawName=rawName;
            this.Price = price;
        }
    }
}
