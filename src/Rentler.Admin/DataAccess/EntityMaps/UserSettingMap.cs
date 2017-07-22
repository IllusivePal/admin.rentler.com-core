using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class UserSettingMap: IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSetting>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_UserSettings");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserSetting)
                    .HasForeignKey<UserSetting>(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserSettings_UserSettings");
            });


        }
    }
}
