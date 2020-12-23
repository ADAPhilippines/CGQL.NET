using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class UtxoViewMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.UtxoView>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.UtxoView> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("utxo_view", "public");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .HasColumnName("id")
                .HasColumnType("bigint");

            builder.Property(t => t.TxId)
                .HasColumnName("tx_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Index)
                .HasColumnName("index")
                .HasColumnType("smallint");

            builder.Property(t => t.Address)
                .HasColumnName("address")
                .HasColumnType("character varying");

            builder.Property(t => t.AddressRaw)
                .HasColumnName("address_raw")
                .HasColumnType("bytea");

            builder.Property(t => t.PaymentCred)
                .HasColumnName("payment_cred")
                .HasColumnType("bytea");

            builder.Property(t => t.StakeAddressId)
                .HasColumnName("stake_address_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Value)
                .HasColumnName("value")
                .HasColumnType("numeric(20,0)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "utxo_view";
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
