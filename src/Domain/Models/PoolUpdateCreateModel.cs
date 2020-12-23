using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class PoolUpdateCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long HashId { get; set; }

        public int CertIndex { get; set; }

        public Byte[] VrfKeyHash { get; set; }

        public decimal Pledge { get; set; }

        public long ActiveEpochNo { get; set; }

        public long? MetaId { get; set; }

        public double Margin { get; set; }

        public decimal FixedCost { get; set; }

        public long RegisteredTxId { get; set; }

        public Byte[] RewardAddr { get; set; }

        #endregion

    }
}
