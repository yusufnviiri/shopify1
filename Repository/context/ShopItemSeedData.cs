using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.context
{
   public class ShopItemSeedData : IEntityTypeConfiguration<ShopItem>
    {
        public void Configure(EntityTypeBuilder<ShopItem> builder)
        {
            builder.HasData(new ShopItem { ShopItemId = 1, ShopItemName = "Lenovo Think Pad ", ShopItemDescription = "Lenovo T430 i7 series with a built-in battery pack ", RoomId = 1 }, new ShopItem { ShopItemId = 2, ShopItemName = "GL360 Camera", ShopItemDescription = "A high resolution camera with backup battery ", RoomId = 2 }, new ShopItem { ShopItemId = 3, ShopItemName = "XBox Game Console", ShopItemDescription = "This brand new console belongs the the XRNM model series with NVDIA accerelators", RoomId = 3 }, new ShopItem { ShopItemId = 4, ShopItemName = "RTC293 HP Server ", ShopItemDescription = "i7 server with 64TB RAM provision and upto 200TB storage capacity.Comes with a built-in DHCP multi-port router", RoomId = 1 });
        }
    }
}
