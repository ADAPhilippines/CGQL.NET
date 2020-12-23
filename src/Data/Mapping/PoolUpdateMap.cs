using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class PoolUpdateMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.PoolUpdate>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.PoolUpdate> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("pool_update", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.HashId)
                .IsRequired()
                .HasColumnName("hash_id")
                .HasColumnType("bigint");

            builder.Property(t => t.CertIndex)
                .IsRequired()
                .HasColumnName("cert_index")
                .HasColumnType("integer");

            builder.Property(t => t.VrfKeyHash)
                .IsRequired()
                .HasColumnName("vrf_key_hash")
                .HasColumnType("bytea");

            builder.Property(t => t.Pledge)
                .IsRequired()
                .HasColumnName("pledge")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.ActiveEpochNo)
                .IsRequired()
                .HasColumnName("active_epoch_no")
                .HasColumnType("bigint");

            builder.Property(t => t.MetaId)
                .HasColumnName("meta_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Margin)
                .IsRequired()
                .HasColumnName("margin")
                .HasColumnType("double precision");

            builder.Property(t => t.FixedCost)
                .IsRequired()
                .HasColumnName("fixed_cost")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.RegisteredTxId)
                .IsRequired()
                .HasColumnName("registered_tx_id")
                .HasColumnType("bigint");

            builder.Property(t => t.RewardAddr)
                .IsRequired()
                .HasColumnName("reward_addr")
                .HasColumnType("bytea");

            // relationships
            builder.HasOne(t => t.HashPoolHash)
                .WithMany(t => t.HashPoolUpdates)
                .HasForeignKey(d => d.HashId)
                .HasConstraintName("pool_update_hash_id_fkey");

            builder.HasOne(t => t.MetaPoolMetaData)
                .WithMany(t => t.MetaPoolUpdates)
                .HasForeignKey(d => d.MetaId)
                .HasConstraintName("pool_update_meta_id_fkey");

            builder.HasOne(t => t.RegisteredTx)
                .WithMany(t => t.RegisteredPoolUpdates)
                .HasForeignKey(d => d.RegisteredTxId)
                .HasConstraintName("pool_update_registered_tx_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "pool_update";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string HashId = "hash_id";
            public const string CertIndex = "cert_index";
            public const string VrfKeyHash = "vrf_key_hash";
            public const string Pledge = "pledge";
            public const string ActiveEpochNo = "active_epoch_no";
            public const string MetaId = "meta_id";
            public const string Margin = "margin";
            public const string FixedCost = "fixed_cost";
            public const string RegisteredTxId = "registered_tx_id";
            public const string RewardAddr = "reward_addr";
        }
        #endregion
    }
}
