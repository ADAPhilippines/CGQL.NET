using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class TxMetadataMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.TxMetadata>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.TxMetadata> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tx_metadata", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Key)
                .IsRequired()
                .HasColumnName("key")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.Json)
                .HasColumnName("json")
                .HasColumnType("jsonb");

            builder.Property(t => t.TxId)
                .IsRequired()
                .HasColumnName("tx_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Bytes)
                .IsRequired()
                .HasColumnName("bytes")
                .HasColumnType("bytea");

            // relationships
            builder.HasOne(t => t.Tx)
                .WithMany(t => t.TxMetadata)
                .HasForeignKey(d => d.TxId)
                .HasConstraintName("tx_metadata_tx_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "tx_metadata";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Key = "key";
            public const string Json = "json";
            public const string TxId = "tx_id";
            public const string Bytes = "bytes";
        }
        #endregion
    }
}
