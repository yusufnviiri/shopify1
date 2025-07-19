using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repo
{
   public interface IShopItemRepo
    {
        Task<IEnumerable<ShopItem>> GetAllShopItems(bool trackChanges);
        Task<ShopItem> FindRoomShopItem(int id,int roomId, bool trackChanges);
        Task<ShopItem> FindShopItem(int id,bool trackChanges);
        Task<PagedList<ShopItem>> FindRoomShopItems(int roomId, bool trackChanges, ShopItemParameters shopItemParameters);

        void CreateShopItem(ShopItem shopItem);
    }
}
