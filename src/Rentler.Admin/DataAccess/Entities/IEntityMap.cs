using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.DataAccess.Entities
{
    public interface IEntityMap
    {
        void Map(ModelBuilder modelBuilder);
    }
}
