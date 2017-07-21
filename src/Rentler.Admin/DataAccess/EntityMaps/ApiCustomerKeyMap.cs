using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ApiCustomerKeyMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiCustomerKey>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ApiName })
                    .HasName("PK_ApiCustomerKeys");

                entity.Property(e => e.ApiName).HasMaxLength(100);

                entity.Property(e => e.ConnectionString).HasMaxLength(500);

                entity.HasOne(d => d.ApiCustomer)
                    .WithMany(p => p.ApiCustomerKeys)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApiCustomerKeys_ApiCustomers");
            });
        }
    }
}
