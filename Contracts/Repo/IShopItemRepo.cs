using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repo
{
   public interface IShopItemRepo
    {
        IEnumerable<ShopItem> GetAllShopItems(bool trackChanges);
        ShopItem FindRoomShopItem(int id,int roomId, bool trackChanges);
        ShopItem FindShopItem(int id,bool trackChanges);
        void CreateShopItem(ShopItem shopItem);
    }
}
