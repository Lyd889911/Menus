using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Users
{
    /// <summary>
    /// 用户登录失败
    /// </summary>
    public class UserLoginFail : Entity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        private bool isLocked;
        public DateTime? LockEnd { get; set; }
        public int LoginFailCount { get; set; }

        private UserLoginFail()
        {

        }
        public UserLoginFail(User user)
        {
            this.User = user;
            this.UserId = user.Id;
            this.Id=Guid.NewGuid();
            isLocked = false;
        }
        #region 充血模型
        /// <summary>重置</summary>
        public void Reset()
        {
            LoginFailCount = 0;
            LockEnd = null;
            isLocked = false;
        }
        /// <summary>判断用户是否被锁定</summary>
        public bool IsLocked()
        {
            if (isLocked)
            {
                if (DateTime.Now > LockEnd)
                {
                    Reset();
                    return false;
                }
                else
                    return true;
            }
            else
                return false;
        }
        /// <summary>登录失败</summary>
        public void AccessFail()
        {
            LoginFailCount++;
            if (LoginFailCount > 3)
                Lock();
        }
        /// <summary>锁定</summary>
        public void Lock()
        {
            LockEnd = DateTime.Now.AddMinutes(5);
            isLocked = true;
        }
        #endregion
    }
}
