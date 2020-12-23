using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class DelegationReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long AddrId { get; set; }

        public int CertIndex { get; set; }

        public long PoolHashId { get; set; }

        public long ActiveEpochNo { get; set; }

        public long TxId { get; set; }

        #endregion

    }
}
