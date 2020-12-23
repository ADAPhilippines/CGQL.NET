using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CGQL.NET.Server.Data
{
    public partial class CardanoDbContext : DbContext
    {
        public CardanoDbContext(DbContextOptions<CardanoDbContext> options)
           : base(options)
        {

        }
        #region Generated Properties
        public virtual DbSet<CGQL.NET.Server.Data.Entities.Block> Blocks { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Delegation> Delegations { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Epoch> Epoches { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.EpochParam> EpochParams { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.EpochStake> EpochStakes { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.MaTxMint> MaTxMints { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.MaTxOut> MaTxOuts { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Meta> Meta { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.ParamProposal> ParamProposals { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.PoolHash> PoolHashes { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.PoolMetaData> PoolMetaData { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.PoolOwner> PoolOwners { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.PoolRelay> PoolRelays { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.PoolRetire> PoolRetires { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.PoolUpdate> PoolUpdates { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Reserve> Reserves { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Reward> Rewards { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.SchemaVersion> SchemaVersions { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.SlotLeader> SlotLeaders { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.StakeAddress> StakeAddresses { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.StakeDeregistration> StakeDeregistrations { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.StakeRegistration> StakeRegistrations { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Treasury> Treasuries { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Tx> Txes { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.TxIn> TxIns { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.TxMetadata> TxMetadata { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.TxOut> TxOuts { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.UtxoView> UtxoViews { get; set; } = default!;

        public virtual DbSet<CGQL.NET.Server.Data.Entities.Withdrawal> Withdrawals { get; set; } = default!;

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.BlockMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.DelegationMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.EpochMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.EpochParamMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.EpochStakeMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.MaTxMintMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.MaTxOutMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.MetaMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.ParamProposalMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.PoolHashMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.PoolMetaDataMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.PoolOwnerMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.PoolRelayMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.PoolRetireMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.PoolUpdateMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.ReserveMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.RewardMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.SchemaVersionMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.SlotLeaderMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.StakeAddressMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.StakeDeregistrationMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.StakeRegistrationMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.TreasuryMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.TxInMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.TxMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.TxMetadataMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.TxOutMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.UtxoViewMap());
            modelBuilder.ApplyConfiguration(new CGQL.NET.Server.Data.Mapping.WithdrawalMap());
            #endregion
        }
    }
}
