using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class TxMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.Tx>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.Tx> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tx", "public");

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

            builder.Property(t => t.BlockId)
                .IsRequired()
                .HasColumnName("block_id")
                .HasColumnType("bigint");

            builder.Property(t => t.BlockIndex)
                .IsRequired()
                .HasColumnName("block_index")
                .HasColumnType("integer");

            builder.Property(t => t.OutSum)
                .IsRequired()
                .HasColumnName("out_sum")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.Fee)
                .IsRequired()
                .HasColumnName("fee")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.Deposit)
                .IsRequired()
                .HasColumnName("deposit")
                .HasColumnType("bigint");

            builder.Property(t => t.Size)
                .IsRequired()
                .HasColumnName("size")
                .HasColumnType("integer");

            builder.Property(t => t.InvalidBefore)
                .HasColumnName("invalid_before")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.InvalidHereafter)
                .HasColumnName("invalid_hereafter")
                .HasColumnType("numeric(20,0)");

            // relationships
            builder.HasOne(t => t.Block)
                .WithMany(t => t.Txes)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("tx_block_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "tx";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Hash = "hash";
            public const string BlockId = "block_id";
            public const string BlockIndex = "block_index";
            public const string OutSum = "out_sum";
            public const string Fee = "fee";
            public const string Deposit = "deposit";
            public const string Size = "size";
            public const string InvalidBefore = "invalid_before";
            public const string InvalidHereafter = "invalid_hereafter";
        }
        #endregion
    }
}
