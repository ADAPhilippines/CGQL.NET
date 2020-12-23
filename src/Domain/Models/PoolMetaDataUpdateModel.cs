using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class PoolMetaDataUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public string Url { get; set; }

        public Byte[] Hash { get; set; }

        public long RegisteredTxId { get; set; }

        #endregion

    }
}
