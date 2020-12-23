using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class MaTxOut
    {
        public MaTxOut()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Policy { get; set; }

        public Byte[] Name { get; set; }

        public decimal Quantity { get; set; }

        public long TxOutId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual TxOut TxOut { get; set; }

        #endregion

    }
}
