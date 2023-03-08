using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus.Shared.BaseEntities
{
    /// <summary>
    /// 聚合根
    /// </summary>
    public abstract class AggregateRoot:Entity, IHasCreationCreator, IHasDeleteCreator, IHasModificationCreator,IHasSoftDelete
    {
        public DateTime? LastModificationTime { get; set; }
        public Guid? LastModifierId { get; set; }
        public Guid? DeleteCreatorId { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime CreationTime { get; set; }
        protected AggregateRoot()
        {

        }
        protected AggregateRoot(Guid CreatorId)
        {
            Id = Guid.NewGuid();
            LastModificationTime = DateTime.Now;
            CreationTime=DateTime.Now;
            this.CreatorId=CreatorId;
            LastModifierId = CreatorId;
            IsDeleted=false;
        }
    }
}
