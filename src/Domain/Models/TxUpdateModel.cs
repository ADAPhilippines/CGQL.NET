using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class TxUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public long BlockId { get; set; }

        public int BlockIndex { get; set; }

        public decimal OutSum { get; set; }

        public decimal Fee { get; set; }

        public long Deposit { get; set; }

        public int Size { get; set; }

        public decimal? InvalidBefore { get; set; }

        public decimal? InvalidHereafter { get; set; }

        #endregion

    }
}
