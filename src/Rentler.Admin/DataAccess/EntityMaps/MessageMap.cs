using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class MessageMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_Messages");

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsRemovedByRecipient).HasDefaultValueSql("0");

                entity.Property(e => e.IsRemovedBySender).HasDefaultValueSql("0");

                entity.Property(e => e.SmsPhoneNumber).HasMaxLength(25);

                entity.HasOne(d => d.Thread)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ThreadId)
                    .HasConstraintName("FK_dbo_Messages_dbo_Threads_ThreadId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo_Messages_dbo_Users_UserId");
            });

        }
    }
}
