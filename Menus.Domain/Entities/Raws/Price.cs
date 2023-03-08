using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Raws
{
    /// <summary>
    /// 原料价格
    /// </summary>
    public class Price
    {
        /// <summary>金额</summary>
        public decimal Money { get; set; }

        /// <summary>数量</summary>
        public decimal Num { get; set; }

        /// <summary>数量</summary>
        public string NumUnit { get; set; }

        /// <summary>最小单位金额</summary>
        public decimal MinUnitMoney { get=> Money / Num; }
    }
}
