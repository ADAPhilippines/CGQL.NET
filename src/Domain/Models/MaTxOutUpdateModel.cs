using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class MaTxOutUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Policy { get; set; }

        public Byte[] Name { get; set; }

        public decimal Quantity { get; set; }

        public long TxOutId { get; set; }

        #endregion

    }
}
