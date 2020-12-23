using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class RewardMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.Reward>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.Reward> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("reward", "public");

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

            builder.Property(t => t.Amount)
                .IsRequired()
                .HasColumnName("amount")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.EpochNo)
                .IsRequired()
                .HasColumnName("epoch_no")
                .HasColumnType("bigint");

            builder.Property(t => t.PoolId)
                .IsRequired()
                .HasColumnName("pool_id")
                .HasColumnType("bigint");

            builder.Property(t => t.BlockId)
                .IsRequired()
                .HasColumnName("block_id")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.AddrStakeAddress)
                .WithMany(t => t.AddrRewards)
                .HasForeignKey(d => d.AddrId)
                .HasConstraintName("reward_addr_id_fkey");

            builder.HasOne(t => t.PoolPoolHash)
                .WithMany(t => t.PoolRewards)
                .HasForeignKey(d => d.PoolId)
                .HasConstraintName("reward_pool_id_fkey");

            builder.HasOne(t => t.Block)
                .WithMany(t => t.Rewards)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("reward_block_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "reward";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string AddrId = "addr_id";
            public const string Amount = "amount";
            public const string EpochNo = "epoch_no";
            public const string PoolId = "pool_id";
            public const string BlockId = "block_id";
        }
        #endregion
    }
}
