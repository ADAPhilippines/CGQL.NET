using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class EpochStakeReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long AddrId { get; set; }

        public long PoolId { get; set; }

        public decimal Amount { get; set; }

        public long EpochNo { get; set; }

        public long BlockId { get; set; }

        #endregion

    }
}
