using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CGQL.NET.Server.Data.Mapping
{
    public partial class BlockMap
        : IEntityTypeConfiguration<CGQL.NET.Server.Data.Entities.Block>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CGQL.NET.Server.Data.Entities.Block> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("block", "public");

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

            builder.Property(t => t.EpochNo)
                .HasColumnName("epoch_no")
                .HasColumnType("integer");

            builder.Property(t => t.SlotNo)
                .HasColumnName("slot_no")
                .HasColumnType("integer");

            builder.Property(t => t.EpochSlotNo)
                .HasColumnName("epoch_slot_no")
                .HasColumnType("integer");

            builder.Property(t => t.BlockNo)
                .HasColumnName("block_no")
                .HasColumnType("integer");

            builder.Property(t => t.PreviousId)
                .HasColumnName("previous_id")
                .HasColumnType("bigint");

            builder.Property(t => t.MerkelRoot)
                .HasColumnName("merkel_root")
                .HasColumnType("bytea");

            builder.Property(t => t.SlotLeaderId)
                .IsRequired()
                .HasColumnName("slot_leader_id")
                .HasColumnType("bigint");

            builder.Property(t => t.Size)
                .IsRequired()
                .HasColumnName("size")
                .HasColumnType("integer");

            builder.Property(t => t.Time)
                .IsRequired()
                .HasColumnName("time")
                .HasColumnType("timestamp without time zone");

            builder.Property(t => t.TxCount)
                .IsRequired()
                .HasColumnName("tx_count")
                .HasColumnType("bigint");

            builder.Property(t => t.ProtoMajor)
                .IsRequired()
                .HasColumnName("proto_major")
                .HasColumnType("integer");

            builder.Property(t => t.ProtoMinor)
                .IsRequired()
                .HasColumnName("proto_minor")
                .HasColumnType("integer");

            builder.Property(t => t.VrfKey)
                .HasColumnName("vrf_key")
                .HasColumnType("character varying");

            builder.Property(t => t.OpCert)
                .HasColumnName("op_cert")
                .HasColumnType("bytea");

            // relationships
            builder.HasOne(t => t.PreviousBlock)
                .WithMany(t => t.PreviousBlocks)
                .HasForeignKey(d => d.PreviousId)
                .HasConstraintName("block_previous_id_fkey");

            builder.HasOne(t => t.SlotLeader)
                .WithMany(t => t.Blocks)
                .HasForeignKey(d => d.SlotLeaderId)
                .HasConstraintName("block_slot_leader_id_fkey");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "public";
            public const string Name = "block";
        }

        public struct Columns
        {
            public const string Id = "id";
            public const string Hash = "hash";
            public const string EpochNo = "epoch_no";
            public const string SlotNo = "slot_no";
            public const string EpochSlotNo = "epoch_slot_no";
            public const string BlockNo = "block_no";
            public const string PreviousId = "previous_id";
            public const string MerkelRoot = "merkel_root";
            public const string SlotLeaderId = "slot_leader_id";
            public const string Size = "size";
            public const string Time = "time";
            public const string TxCount = "tx_count";
            public const string ProtoMajor = "proto_major";
            public const string ProtoMinor = "proto_minor";
            public const string VrfKey = "vrf_key";
            public const string OpCert = "op_cert";
        }
        #endregion
    }
}
