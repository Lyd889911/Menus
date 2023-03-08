using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.UserHistorys
{
    /// <summary>
    /// 登录结果，值对象
    /// </summary>
    public class LoginResult
    {
        /// <summary>是否登录成功</summary>
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }
}
