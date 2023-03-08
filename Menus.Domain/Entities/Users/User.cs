using Menus.Shared;
using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Users
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User: AggregateRoot
    {
        public string UserName { get; set; }
        public string? Password { get; private set; }
        public string? NickName { get; set; }
        public Guid? AvatarImgId { get; set; }
        public DateTime? Birth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public UserLoginFail UserLoginFail { get; set; }
        public Guid RoleId { get; set; }
        public User(string userName,Guid roleId,Guid Creator)
            :base(Creator)
        {
            UserName = userName;
            RoleId = roleId;
            UserLoginFail = new UserLoginFail(this);
        }
        private User()
        {

        }
        #region 充血模型的方法
        /// <summary>有没有密码</summary>
        public bool HasPassword() => !string.IsNullOrEmpty(Password);
        /// <summary>设置密码</summary>
        public void SetPassword(string password)
        {
            if(password.Length<3)
                throw new ArgumentOutOfRangeException("密码长度太短");
            Password = HashHelper.ComputeSha256Hash(password);
        }
        /// <summary>有没有电话</summary>
        public bool HasPhone() => !string.IsNullOrEmpty(Phone);
        /// <summary>设置电话</summary>
        public void SetPhone(string phone)=>Phone= phone;
        /// <summary>有没有头像</summary>
        public bool HasAvatar() => AvatarImgId == null ? false : true;
        /// <summary>设置头像</summary>
        public void SetAvatar(Guid avator)=>AvatarImgId = avator;
        /// <summary>有无邮箱</summary>
        public bool HasEmail() => !string.IsNullOrEmpty(Email);
        /// <summary>设置邮箱</summary>
        public void SetEmail(string email) => Email = email;
        /// <summary>设置生日</summary>
        public void SetBirth(DateTime date)=>Birth = date;
        /// <summary>校验密码</summary>
        public bool CheckPassword(string rawPwd) => HashHelper.ComputeSha256Hash(rawPwd) == Password;
        #endregion

    }
}
