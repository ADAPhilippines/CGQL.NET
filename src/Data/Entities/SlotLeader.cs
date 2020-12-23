using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class SlotLeader
    {
        public SlotLeader()
        {
            #region Generated Constructor
            Blocks = new HashSet<Block>();
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public long? PoolHashId { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Block> Blocks { get; set; }

        public virtual PoolHash PoolHash { get; set; }

        #endregion

    }
}
