using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class Reward
    {
        public Reward()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long AddrId { get; set; }

        public decimal Amount { get; set; }

        public long EpochNo { get; set; }

        public long PoolId { get; set; }

        public long BlockId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual StakeAddress AddrStakeAddress { get; set; }

        public virtual Block Block { get; set; }

        public virtual PoolHash PoolPoolHash { get; set; }

        #endregion

    }
}
