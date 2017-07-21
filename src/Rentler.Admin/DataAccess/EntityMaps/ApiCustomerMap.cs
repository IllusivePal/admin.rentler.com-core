using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rentler.Admin.DataAccess.Entities;

namespace Rentler.Admin.DataAccess
{
    public class ApiCustomerMap:IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_ApiCustomers");

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
