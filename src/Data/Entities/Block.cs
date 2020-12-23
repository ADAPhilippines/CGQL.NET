using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class Block
    {
        public Block()
        {
            #region Generated Constructor
            EpochParams = new HashSet<EpochParam>();
            EpochStakes = new HashSet<EpochStake>();
            PreviousBlocks = new HashSet<Block>();
            Rewards = new HashSet<Reward>();
            Txes = new HashSet<Tx>();
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public int? EpochNo { get; set; }

        public int? SlotNo { get; set; }

        public int? EpochSlotNo { get; set; }

        public int? BlockNo { get; set; }

        public long? PreviousId { get; set; }

        public long SlotLeaderId { get; set; }

        public int Size { get; set; }

        public DateTime Time { get; set; }

        public long TxCount { get; set; }

        public int ProtoMajor { get; set; }

        public int ProtoMinor { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<EpochParam> EpochParams { get; set; }

        public virtual ICollection<EpochStake> EpochStakes { get; set; }

        public virtual Block PreviousBlock { get; set; }

        public virtual ICollection<Block> PreviousBlocks { get; set; }

        public virtual ICollection<Reward> Rewards { get; set; }

        public virtual SlotLeader SlotLeader { get; set; }

        public virtual ICollection<Tx> Txes { get; set; }

        #endregion
        public string? VrfKey { get; set; }
        public Byte[]? OpCert { get; set; }
        public Byte[]? MerkelRoot { get; set; }
    }
}
