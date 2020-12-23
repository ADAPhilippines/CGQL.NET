using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Domain.Models
{
    public partial class SlotLeaderReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public long? PoolHashId { get; set; }

        public string Description { get; set; }

        #endregion

    }
}
