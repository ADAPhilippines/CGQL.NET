using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class TxOutMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.TxOut>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.TxOut> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tx_out", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TxId)
                .IsRequired()
                .HasColumnName("tx_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Index)
                .IsRequired()
                .HasColumnName("index")
                .HasColumnType("smallint");

            builder.Property(t => t.Address)
                .IsRequired()
                .HasColumnName("address")
                .HasColumnType("character varying");

            builder.Property(t => t.AddressRaw)
                .IsRequired()
                .HasColumnName("address_raw")
                .HasColumnType("bytea");

            builder.Property(t => t.PaymentCred)
                .HasColumnName("payment_cred")
                .HasColumnType("bytea");

            builder.Property(t => t.StakeAddressId)
                .HasColumnName("stake_address_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("value")
                .HasColumnType("numeric(20,0)");

            // relationships
            builder.HasOne(t => t.Tx)
                .WithMany(t => t.TxOuts)
                .HasForeignKey(d => d.TxId)
                .HasConstraintName("tx_out_tx_id_fkey");

            builder.HasOne(t => t.StakeAddress)
                .WithMany(t => t.TxOuts)
                .HasForeignKey(d => d.StakeAddressId)
                .HasConstraintName("tx_out_stake_address_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "tx_out";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string TxId = "tx_id";
            public const string Index = "index";
            public const string Address = "address";
            public const string AddressRaw = "address_raw";
            public const string PaymentCred = "payment_cred";
            public const string StakeAddressId = "stake_address_id";
            public const string Value = "value";
        }
        #endregion
    }
}
