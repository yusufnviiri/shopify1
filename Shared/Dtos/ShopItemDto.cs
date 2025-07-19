using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
  public record ShopItemDto(int ShopItemId, string? ShopItemName, string? ShopItemDescription)
    {
    }
}
