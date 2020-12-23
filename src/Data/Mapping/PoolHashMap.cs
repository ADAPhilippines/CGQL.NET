using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class PoolHashMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.PoolHash>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.PoolHash> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("pool_hash", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.HashRaw)
                .IsRequired()
                .HasColumnName("hash_raw")
                .HasColumnType("bytea");

            builder.Property(t => t.View)
                .IsRequired()
                .HasColumnName("view")
                .HasColumnType("character varying");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "pool_hash";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string HashRaw = "hash_raw";
            public const string View = "view";
        }
        #endregion
    }
}
