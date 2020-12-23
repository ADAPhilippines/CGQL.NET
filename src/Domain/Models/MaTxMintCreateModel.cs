using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class MaTxMintCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Policy { get; set; }

        public Byte[] Name { get; set; }

        public decimal Quantity { get; set; }

        public long TxId { get; set; }

        #endregion

    }
}
