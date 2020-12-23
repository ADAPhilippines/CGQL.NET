using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class BlockCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public int? EpochNo { get; set; }

        public int? SlotNo { get; set; }

        public int? EpochSlotNo { get; set; }

        public int? BlockNo { get; set; }

        public long? PreviousId { get; set; }

        public Byte[] MerkelRoot { get; set; }

        public long SlotLeaderId { get; set; }

        public int Size { get; set; }

        public DateTime Time { get; set; }

        public long TxCount { get; set; }

        public int ProtoMajor { get; set; }

        public int ProtoMinor { get; set; }

        public string VrfKey { get; set; }

        public Byte[] OpCert { get; set; }

        #endregion

    }
}
