﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System.IO;

using Microsoft.EntityFrameworkCore;

namespace WhatsAppTools.Core.iOS
{
    partial class ChatStorageContext : DbContext
    {
        readonly FileInfo _chatStorageFile;

        public ChatStorageContext(FileInfo chatStorageFile)
        {
            _chatStorageFile = chatStorageFile;
        }

        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"data source={_chatStorageFile.FullName}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasIndex(e => e.Zchatsession)
                    .HasName("ZWAMESSAGE_ZCHATSESSION_INDEX");

                entity.HasIndex(e => e.Zdocid)
                    .HasName("Z_WAMessage_docID");

                entity.HasIndex(e => e.Zgroupmember)
                    .HasName("ZWAMESSAGE_ZGROUPMEMBER_INDEX");

                entity.HasIndex(e => e.Zlastsession)
                    .HasName("ZWAMESSAGE_ZLASTSESSION_INDEX");

                entity.HasIndex(e => e.Zmediaitem)
                    .HasName("ZWAMESSAGE_ZMEDIAITEM_INDEX");

                entity.HasIndex(e => e.ZmessageDate)
                    .HasName("Z_WAMessage_messageDate");

                entity.HasIndex(e => e.Zmessageerrorstatus)
                    .HasName("Z_WAMessage_messageErrorStatus");

                entity.HasIndex(e => e.Zmessageinfo)
                    .HasName("ZWAMESSAGE_ZMESSAGEINFO_INDEX");

                entity.HasIndex(e => e.Zmessagestatus)
                    .HasName("Z_WAMessage_messageStatus");

                entity.HasIndex(e => e.Zmessagetype)
                    .HasName("Z_WAMessage_messageType");

                entity.HasIndex(e => e.Zparentmessage)
                    .HasName("ZWAMESSAGE_ZPARENTMESSAGE_INDEX");

                entity.HasIndex(e => e.Zsort)
                    .HasName("Z_WAMessage_sort");

                entity.HasIndex(e => e.Zstanzaid)
                    .HasName("Z_WAMessage_stanzaID");

                entity.HasIndex(e => e.Starred)
                    .HasName("Z_WAMessage_starred");

                entity.HasIndex(e => new { e.Zchatsession, e.Zsort })
                    .HasName("ZWAMESSAGE_ZCHATSESSION_ZSORT");

                entity.HasIndex(e => new { e.Zdataitemversion, e.ZmessageDate })
                    .HasName("Z_WAMessage_dataItemVersion_messageDate");

                entity.HasIndex(e => new { e.Zspotlightstatus, e.ZmessageDate })
                    .HasName("Z_WAMessage_spotlightStatus_messageDate");

                entity.HasIndex(e => new { e.Zchatsession, e.Zmediasectionid, e.Zsort })
                    .HasName("ZWAMESSAGE_ZCHATSESSION_ZMEDIASECTIONID_ZSORT");

                entity.HasIndex(e => new { e.Zchatsession, e.Starred, e.ZmessageDate })
                    .HasName("ZWAMESSAGE_ZCHATSESSION_ZSTARRED_ZMESSAGEDATE");

                entity.Property(e => e.ZPk).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}