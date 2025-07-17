using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository.context
{
   public class RoomSeedData : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasData(
                new Room { RoomId = 1, RoomName = "Lati Technologies", RoomOwner = "Martin Lubega" },
                new Room { RoomId = 2, RoomName = "DreamLand", RoomOwner = "Isaac" },
                new Room { RoomId = 3, RoomName = "Pete Games", RoomOwner = "Leonard" });
        }
    }
}// This code defines a seed data configuration for the Room entity in an Entity Framework Core context.
