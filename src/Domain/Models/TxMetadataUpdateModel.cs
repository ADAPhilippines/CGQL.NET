using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class TxMetadataUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public decimal Key { get; set; }

        public string Json { get; set; }

        public long TxId { get; set; }

        public Byte[] Bytes { get; set; }

        #endregion

    }
}
