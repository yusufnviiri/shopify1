using Shared.Dtos;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
   public interface IShopItemService
    {
       Task< IEnumerable<ShopItemDto>> GetAllShopItemsService(bool trackChanges);
      Task<ShopItemDto> FindShopItemService(int id, bool trackChanges);
        Task<ShopItemDto> FindRoomShopItemService(int id,int roomId, bool trackChanges);
        Task<ShopItemDto> AddShopItem(NewShopItemDto shopItemdto);
        Task<(IEnumerable<ShopItemDto> shopItems, MetaData metaData)> FindRoomShopItems(int roomId, bool trackChanges, ShopItemParameters shopItemParameters);

    }
}
