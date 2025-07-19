using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
   public interface IShopItemService
    {
        IEnumerable<ShopItemDto> GetAllShopItemsService(bool trackChanges);
        ShopItemDto FindShopItemService(int id, bool trackChanges);
        ShopItemDto FindRoomShopItemService(int id,int roomId, bool trackChanges);
        Task<ShopItemDto> AddShopItem(NewShopItemDto shopItemdto);
    }
}
