using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ArticleMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK_Articles");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreateDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDateUtc).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.Author)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articles_Users");

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.BlogId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articles_Blogs");
            });

        }
    }
}
