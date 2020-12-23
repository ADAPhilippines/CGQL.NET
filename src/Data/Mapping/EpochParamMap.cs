using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class EpochParamMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.EpochParam>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.EpochParam> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("epoch_param", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.EpochNo)
                .IsRequired()
                .HasColumnName("epoch_no")
                .HasColumnType("integer");

            builder.Property(t => t.MinFeea)
                .IsRequired()
                .HasColumnName("min_fee_a")
                .HasColumnType("integer");

            builder.Property(t => t.MinFeeb)
                .IsRequired()
                .HasColumnName("min_fee_b")
                .HasColumnType("integer");

            builder.Property(t => t.MaxBlockSize)
                .IsRequired()
                .HasColumnName("max_block_size")
                .HasColumnType("integer");

            builder.Property(t => t.MaxTxSize)
                .IsRequired()
                .HasColumnName("max_tx_size")
                .HasColumnType("integer");

            builder.Property(t => t.MaxBhSize)
                .IsRequired()
                .HasColumnName("max_bh_size")
                .HasColumnType("integer");

            builder.Property(t => t.KeyDeposit)
                .IsRequired()
                .HasColumnName("key_deposit")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.PoolDeposit)
                .IsRequired()
                .HasColumnName("pool_deposit")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.MaxEpoch)
                .IsRequired()
                .HasColumnName("max_epoch")
                .HasColumnType("integer");

            builder.Property(t => t.OptimalPoolCount)
                .IsRequired()
                .HasColumnName("optimal_pool_count")
                .HasColumnType("integer");

            builder.Property(t => t.Influence)
                .IsRequired()
                .HasColumnName("influence")
                .HasColumnType("double precision");

            builder.Property(t => t.MonetaryExpandRate)
                .IsRequired()
                .HasColumnName("monetary_expand_rate")
                .HasColumnType("double precision");

            builder.Property(t => t.TreasuryGrowthRate)
                .IsRequired()
                .HasColumnName("treasury_growth_rate")
                .HasColumnType("double precision");

            builder.Property(t => t.Decentralisation)
                .IsRequired()
                .HasColumnName("decentralisation")
                .HasColumnType("double precision");

            builder.Property(t => t.Entropy)
                .HasColumnName("entropy")
                .HasColumnType("bytea");

            builder.Property(t => t.ProtocolMajor)
                .IsRequired()
                .HasColumnName("protocol_major")
                .HasColumnType("integer");

            builder.Property(t => t.ProtocolMinor)
                .IsRequired()
                .HasColumnName("protocol_minor")
                .HasColumnType("integer");

            builder.Property(t => t.MinUtxoValue)
                .IsRequired()
                .HasColumnName("min_utxo_value")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.MinPoolCost)
                .IsRequired()
                .HasColumnName("min_pool_cost")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.Nonce)
                .HasColumnName("nonce")
                .HasColumnType("bytea");

            builder.Property(t => t.BlockId)
                .IsRequired()
                .HasColumnName("block_id")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.Block)
                .WithMany(t => t.EpochParams)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("epoch_param_block_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "epoch_param";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string EpochNo = "epoch_no";
            public const string MinFeea = "min_fee_a";
            public const string MinFeeb = "min_fee_b";
            public const string MaxBlockSize = "max_block_size";
            public const string MaxTxSize = "max_tx_size";
            public const string MaxBhSize = "max_bh_size";
            public const string KeyDeposit = "key_deposit";
            public const string PoolDeposit = "pool_deposit";
            public const string MaxEpoch = "max_epoch";
            public const string OptimalPoolCount = "optimal_pool_count";
            public const string Influence = "influence";
            public const string MonetaryExpandRate = "monetary_expand_rate";
            public const string TreasuryGrowthRate = "treasury_growth_rate";
            public const string Decentralisation = "decentralisation";
            public const string Entropy = "entropy";
            public const string ProtocolMajor = "protocol_major";
            public const string ProtocolMinor = "protocol_minor";
            public const string MinUtxoValue = "min_utxo_value";
            public const string MinPoolCost = "min_pool_cost";
            public const string Nonce = "nonce";
            public const string BlockId = "block_id";
        }
        #endregion
    }
}
