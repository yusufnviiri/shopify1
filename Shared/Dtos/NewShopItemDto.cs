﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
          public record NewShopItemDto(string ShopItemName, string ShopItemDescription, int RoomId) { }
}
