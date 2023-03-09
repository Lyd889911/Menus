using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Menus
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class Menu:AggregateRoot
    {
        /// <summary>菜名</summary>
        public string DishName { get; set; }

        /// <summary>菜名类型</summary>
        public DishType DishType { get; set; }

        /// <summary>辣度类型</summary>
        public string Spiciness { get; set; }

        /// <summary>评分</summary>
        public Rating Rating { get; set; }

        /// <summary>图片id</summary>
        public Guid ImgId { get; set; }

        /// <summary>做法内容</summary>
        public string Content { get; set; }

        /// <summary>使用的食物</summary>
        public Food Food { get; set; }
        public Menu(string dishName, DishType dishType, Guid imgId, string content, Food food,Guid CreatorId)
            :base(CreatorId)
        {
            DishName = dishName;
            DishType = dishType;
            ImgId = imgId;
            Content = content;
            Food = food;
        }
        #region 充血模型
        public void SetRating(Rating rating)
        {
            if (rating.Self > 10 || rating.Others > 10 || rating.Self < 0 || rating.Others < 0)
                throw new ArgumentOutOfRangeException("评分只能0-10");
            Rating = rating;
        }
        #endregion
    }
}
