using System;
using System.Collections.Generic;

namespace CGQL.NET.Server.Data.Entities
{
    public partial class Tx
    {
        public Tx()
        {
            #region Generated Constructor
            AnnouncedPoolRetires = new HashSet<PoolRetire>();
            Delegations = new HashSet<Delegation>();
            InTxIns = new HashSet<TxIn>();
            MaTxMints = new HashSet<MaTxMint>();
            OutTxIns = new HashSet<TxIn>();
            RegisteredParamProposals = new HashSet<ParamProposal>();
            RegisteredPoolMetaData = new HashSet<PoolMetaData>();
            RegisteredPoolOwners = new HashSet<PoolOwner>();
            RegisteredPoolUpdates = new HashSet<PoolUpdate>();
            RegisteredStakeAddresses = new HashSet<StakeAddress>();
            Reserves = new HashSet<Reserve>();
            StakeDeregistrations = new HashSet<StakeDeregistration>();
            StakeRegistrations = new HashSet<StakeRegistration>();
            Treasuries = new HashSet<Treasury>();
            TxMetadata = new HashSet<TxMetadata>();
            TxOuts = new HashSet<TxOut>();
            Withdrawals = new HashSet<Withdrawal>();
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public Byte[] Hash { get; set; }

        public long BlockId { get; set; }

        public int BlockIndex { get; set; }

        public decimal OutSum { get; set; }

        public decimal Fee { get; set; }

        public long Deposit { get; set; }

        public int Size { get; set; }

        public decimal? InvalidBefore { get; set; }

        public decimal? InvalidHereafter { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<PoolRetire> AnnouncedPoolRetires { get; set; }

        public virtual Block Block { get; set; }

        public virtual ICollection<Delegation> Delegations { get; set; }

        public virtual ICollection<TxIn> InTxIns { get; set; }

        public virtual ICollection<MaTxMint> MaTxMints { get; set; }

        public virtual ICollection<TxIn> OutTxIns { get; set; }

        public virtual ICollection<ParamProposal> RegisteredParamProposals { get; set; }

        public virtual ICollection<PoolMetaData> RegisteredPoolMetaData { get; set; }

        public virtual ICollection<PoolOwner> RegisteredPoolOwners { get; set; }

        public virtual ICollection<PoolUpdate> RegisteredPoolUpdates { get; set; }

        public virtual ICollection<StakeAddress> RegisteredStakeAddresses { get; set; }

        public virtual ICollection<Reserve> Reserves { get; set; }

        public virtual ICollection<StakeDeregistration> StakeDeregistrations { get; set; }

        public virtual ICollection<StakeRegistration> StakeRegistrations { get; set; }

        public virtual ICollection<Treasury> Treasuries { get; set; }

        public virtual ICollection<TxMetadata> TxMetadata { get; set; }

        public virtual ICollection<TxOut> TxOuts { get; set; }

        public virtual ICollection<Withdrawal> Withdrawals { get; set; }

        #endregion

    }
}
