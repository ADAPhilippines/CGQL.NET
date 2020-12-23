using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class MaTxMint
    {
        public MaTxMint()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Policy { get; set; }

        public Byte[] Name { get; set; }

        public decimal Quantity { get; set; }

        public long TxId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Tx Tx { get; set; }

        #endregion

    }
}
