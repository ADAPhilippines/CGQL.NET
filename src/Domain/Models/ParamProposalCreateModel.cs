using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class ParamProposalCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int EpochNo { get; set; }

        public Byte[] Key { get; set; }

        public int? MinFeea { get; set; }

        public int? MinFeeb { get; set; }

        public int? MaxBlockSize { get; set; }

        public int? MaxTxSize { get; set; }

        public int? MaxBhSize { get; set; }

        public decimal? KeyDeposit { get; set; }

        public decimal? PoolDeposit { get; set; }

        public int? MaxEpoch { get; set; }

        public int? OptimalPoolCount { get; set; }

        public double? Influence { get; set; }

        public double? MonetaryExpandRate { get; set; }

        public double? TreasuryGrowthRate { get; set; }

        public double? Decentralisation { get; set; }

        public Byte[] Entropy { get; set; }

        public int? ProtocolMajor { get; set; }

        public int? ProtocolMinor { get; set; }

        public decimal? MinUtxoValue { get; set; }

        public decimal? MinPoolCost { get; set; }

        public long RegisteredTxId { get; set; }

        #endregion

    }
}
