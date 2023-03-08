using Menus.Shared.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Domain.Entities.Roles
{

    public class Role:AggregateRoot
    {
        public string? RoleName { get; set; }
        public int Level { get; set; }
        public Role(string? roleName, int level,Guid Creator):base(Creator)
        {
            RoleName = roleName;
            Level = level;
        }
    }
}
