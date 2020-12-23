using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class EpochReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public decimal OutSum { get; set; }

        public decimal Fees { get; set; }

        public int TxCount { get; set; }

        public int BlkCount { get; set; }

        public int No { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        #endregion

    }
}
