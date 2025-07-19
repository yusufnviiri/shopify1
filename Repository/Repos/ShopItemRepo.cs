using Contracts.Repo;
using Entities.Models;
using Repository.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    internal class ShopItemRepo : RepositoryBase<ShopItem>, IShopItemRepo
    {
        public ShopItemRepo(ApplicationDbContext context) : base(context)
        {

        }
      public  IEnumerable<ShopItem> GetAllShopItems(bool trackChanges) => [.. FindAll(trackChanges).OrderBy(k => k.ShopItemName)];

        public  ShopItem FindRoomShopItem(int id, int roomId, bool trackChanges)
        {
            var shopItem = FindByCondition(x => x.ShopItemId == id && x.RoomId == roomId, trackChanges).SingleOrDefault();
            return shopItem;
        }
        public ShopItem FindShopItem(int id,bool trackChanges)
        {
            var shopItem = FindByCondition(x => x.ShopItemId == id , trackChanges).SingleOrDefault();
            return shopItem;
        }
        public void CreateShopItem(ShopItem shopItem) => CreateBase(shopItem);

    }
   
}
