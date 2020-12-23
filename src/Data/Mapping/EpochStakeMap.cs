using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class EpochStakeMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.EpochStake>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.EpochStake> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("epoch_stake", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.AddrId)
                .IsRequired()
                .HasColumnName("addr_id")
                .HasColumnType("bigint");

            builder.Property(t => t.PoolId)
                .IsRequired()
                .HasColumnName("pool_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.EpochNo)
                .IsRequired()
                .HasColumnName("epoch_no")
                .HasColumnType("bigint");

            builder.Property(t => t.BlockId)
                .IsRequired()
                .HasColumnName("block_id")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.AddrStakeAddress)
                .WithMany(t => t.AddrEpochStakes)
                .HasForeignKey(d => d.AddrId)
                .HasConstraintName("epoch_stake_addr_id_fkey");

            builder.HasOne(t => t.PoolPoolHash)
                .WithMany(t => t.PoolEpochStakes)
                .HasForeignKey(d => d.PoolId)
                .HasConstraintName("epoch_stake_pool_id_fkey");

            builder.HasOne(t => t.Block)
                .WithMany(t => t.EpochStakes)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("epoch_stake_block_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "epoch_stake";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string AddrId = "addr_id";
            public const string PoolId = "pool_id";
            public const string Amount = "amount";
            public const string EpochNo = "epoch_no";
            public const string BlockId = "block_id";
        }
        #endregion
    }
}
