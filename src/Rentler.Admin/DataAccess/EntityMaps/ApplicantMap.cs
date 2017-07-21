using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ApplicantMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.HasKey(e => e.ApplicantId)
                    .HasName("PK_Applicants");

                entity.Property(e => e.ApplicantId).ValueGeneratedNever();

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                /*entity.HasOne(d => d.Application)
                    .WithMany(p => p.Applicants)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationInvites_Application");*/

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Applicants)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ApplicationInvites_Users");
            });
        }
    }
}
