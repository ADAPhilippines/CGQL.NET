using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class PoolRetireUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long HashId { get; set; }

        public int CertIndex { get; set; }

        public long AnnouncedTxId { get; set; }

        public int RetiringEpoch { get; set; }

        #endregion

    }
}
