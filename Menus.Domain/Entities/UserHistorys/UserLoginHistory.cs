using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.UserHistorys
{
    /// <summary>
    /// 用户登录历史
    /// </summary>
    public class UserLoginHistory:AggregateRoot
    {
        /// <summary>登录方式，手机，邮箱，用户名</summary>
        public LoginMethod LoginMethod { get; set; }

        /// <summary>登录账号</summary>
        public string Account { get; set; }
        public Guid UserId { get; set; }

        /// <summary>登录结果</summary>
        public LoginResult LoginResult { get; set; }
        public UserLoginHistory(LoginMethod loginMethod, string account, Guid userId, LoginResult loginResult,Guid CreatorId)
            :base(CreatorId)
        {
            LoginMethod = loginMethod;
            Account = account;
            UserId = userId;
            LoginResult = loginResult;
        }
    }
}
