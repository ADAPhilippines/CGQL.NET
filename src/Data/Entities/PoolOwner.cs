using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class PoolOwner
    {
        public PoolOwner()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public long PoolHashId { get; set; }

        public long RegisteredTxId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual PoolHash PoolHash { get; set; }

        public virtual Tx RegisteredTx { get; set; }

        #endregion

    }
}
