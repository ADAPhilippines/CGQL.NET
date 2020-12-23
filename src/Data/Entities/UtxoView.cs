using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class UtxoView
    {
        public UtxoView()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long? Id { get; set; }

        public long? TxId { get; set; }

        public short? Index { get; set; }

        public string Address { get; set; }

        public Byte[] AddressRaw { get; set; }

        public Byte[] PaymentCred { get; set; }

        public long? StakeAddressId { get; set; }

        public decimal? Value { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
