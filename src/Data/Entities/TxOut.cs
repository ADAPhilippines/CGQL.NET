using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class TxOut
    {
        public TxOut()
        {
            #region Generated Constructor
            MaTxOuts = new HashSet<MaTxOut>();
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public long TxId { get; set; }

        public short Index { get; set; }

        public string Address { get; set; }

        public Byte[] AddressRaw { get; set; }

        public Byte[] PaymentCred { get; set; }

        public long? StakeAddressId { get; set; }

        public decimal Value { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<MaTxOut> MaTxOuts { get; set; }

        public virtual StakeAddress StakeAddress { get; set; }

        public virtual Tx Tx { get; set; }

        #endregion

    }
}
