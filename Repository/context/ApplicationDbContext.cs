using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.context
{
    public class ApplicationDbContext: DbContext
{
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoomSeedData());
            modelBuilder.ApplyConfiguration(new ShopItemSeedData());
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }
    }
}
