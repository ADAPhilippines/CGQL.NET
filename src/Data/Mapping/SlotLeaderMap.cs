using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class SlotLeaderMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.SlotLeader>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.SlotLeader> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("slot_leader", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Hash)
                .IsRequired()
                .HasColumnName("hash")
                .HasColumnType("bytea");

            builder.Property(t => t.PoolHashId)
                .HasColumnName("pool_hash_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasColumnType("character varying");

            // relationships
            builder.HasOne(t => t.PoolHash)
                .WithMany(t => t.SlotLeaders)
                .HasForeignKey(d => d.PoolHashId)
                .HasConstraintName("slot_leader_pool_hash_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "slot_leader";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Hash = "hash";
            public const string PoolHashId = "pool_hash_id";
            public const string Description = "description";
        }
        #endregion
    }
}
