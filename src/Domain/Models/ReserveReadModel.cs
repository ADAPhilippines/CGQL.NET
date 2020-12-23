using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class ReserveReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long AddrId { get; set; }

        public int CertIndex { get; set; }

        public decimal Amount { get; set; }

        public long TxId { get; set; }

        #endregion

    }
}
