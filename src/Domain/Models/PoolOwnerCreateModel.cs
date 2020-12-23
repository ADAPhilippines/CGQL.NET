using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class PoolOwnerCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public long PoolHashId { get; set; }

        public long RegisteredTxId { get; set; }

        #endregion

    }
}
