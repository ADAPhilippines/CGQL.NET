using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class MaTxOutMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.MaTxOut>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.MaTxOut> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ma_tx_out", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Policy)
                .IsRequired()
                .HasColumnName("policy")
                .HasColumnType("bytea");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("bytea");

            builder.Property(t => t.Quantity)
                .IsRequired()
                .HasColumnName("quantity")
                .HasColumnType("numeric(20,0)");

            builder.Property(t => t.TxOutId)
                .IsRequired()
                .HasColumnName("tx_out_id")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.TxOut)
                .WithMany(t => t.MaTxOuts)
                .HasForeignKey(d => d.TxOutId)
                .HasConstraintName("ma_tx_out_tx_out_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "ma_tx_out";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Policy = "policy";
            public const string Name = "name";
            public const string Quantity = "quantity";
            public const string TxOutId = "tx_out_id";
        }
        #endregion
    }
}
