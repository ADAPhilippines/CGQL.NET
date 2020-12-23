using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class StakeAddress
    {
        public StakeAddress()
        {
            #region Generated Constructor
            AddrDelegations = new HashSet<Delegation>();
            AddrEpochStakes = new HashSet<EpochStake>();
            AddrReserves = new HashSet<Reserve>();
            AddrRewards = new HashSet<Reward>();
            AddrStakeDeregistrations = new HashSet<StakeDeregistration>();
            AddrStakeRegistrations = new HashSet<StakeRegistration>();
            AddrTreasuries = new HashSet<Treasury>();
            AddrWithdrawals = new HashSet<Withdrawal>();
            TxOuts = new HashSet<TxOut>();
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] HashRaw { get; set; }

        public string View { get; set; }

        public long RegisteredTxId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Delegation> AddrDelegations { get; set; }

        public virtual ICollection<EpochStake> AddrEpochStakes { get; set; }

        public virtual ICollection<Reserve> AddrReserves { get; set; }

        public virtual ICollection<Reward> AddrRewards { get; set; }

        public virtual ICollection<StakeDeregistration> AddrStakeDeregistrations { get; set; }

        public virtual ICollection<StakeRegistration> AddrStakeRegistrations { get; set; }

        public virtual ICollection<Treasury> AddrTreasuries { get; set; }

        public virtual ICollection<Withdrawal> AddrWithdrawals { get; set; }

        public virtual Tx RegisteredTx { get; set; }

        public virtual ICollection<TxOut> TxOuts { get; set; }

        #endregion

    }
}
