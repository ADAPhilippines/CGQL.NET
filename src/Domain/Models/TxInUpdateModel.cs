using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class TxInUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long TxInId { get; set; }

        public long TxOutId { get; set; }

        public short TxOutIndex { get; set; }

        #endregion

    }
}
