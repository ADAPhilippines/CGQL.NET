using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class WithdrawalMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.Withdrawal>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.Withdrawal> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("withdrawal", "public");

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

            builder.Property(t => t.TxId)
                .IsRequired()
                .HasColumnName("tx_id")
                .HasColumnType("bigint");

            // relationships
            builder.HasOne(t => t.AddrStakeAddress)
                .WithMany(t => t.AddrWithdrawals)
                .HasForeignKey(d => d.AddrId)
                .HasConstraintName("withdrawal_addr_id_fkey");

            builder.HasOne(t => t.Tx)
                .WithMany(t => t.Withdrawals)
                .HasForeignKey(d => d.TxId)
                .HasConstraintName("withdrawal_tx_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "withdrawal";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string AddrId = "addr_id";
            public const string Amount = "amount";
            public const string TxId = "tx_id";
        }
        #endregion
    }
}
