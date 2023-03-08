using Menus.Domain.Entities.Raws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Menus
{
    /// <summary>
    /// 食物
    /// </summary>
    public class Food
    {
        public List<Raw> MainFood { get; set; }
        public List<Raw> SideFood { get;set; }
    }
}
