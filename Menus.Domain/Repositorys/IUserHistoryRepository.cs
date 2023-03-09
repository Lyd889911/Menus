using Menus.Domain.Entities.UserHistorys;
using Menus.Domain.Entities.Users;
using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Repositorys
{
    public interface IUserHistoryRepository: IRepository<UserLoginHistory, Guid>
    {
    }
}
