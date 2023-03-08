using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Menus
{
    /// <summary>
    /// 菜品评分
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// 自己评分
        /// </summary>
        public decimal Self { get; set; }
        /// <summary>
        /// 他们评分
        /// </summary>
        public decimal Others { get; set; }
    }
}
