using Contracts.Repo;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.context;
using Shared.RequestFeatures;
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
      public async Task<IEnumerable<ShopItem>> GetAllShopItems(bool trackChanges) => await FindAll(trackChanges).OrderBy(k => k.ShopItemName).ToListAsync();

        public async Task<ShopItem> FindRoomShopItem(int id, int roomId, bool trackChanges)
        {
            var shopItem =await FindByCondition(x => x.ShopItemId == id && x.RoomId == roomId, trackChanges).FirstOrDefaultAsync();
            return shopItem;
        }
        public async Task<ShopItem> FindShopItem(int id,bool trackChanges)
        {
            var shopItem = await FindByCondition(x => x.ShopItemId == id , trackChanges).SingleOrDefaultAsync();
            return shopItem;
        }
        public void CreateShopItem(ShopItem shopItem) => CreateBase(shopItem);
        public async Task<PagedList<ShopItem>> FindRoomShopItems(int roomId, bool trackChanges, ShopItemParameters shopItemParameters)
        { 
       var shopItems = await FindByCondition(x => x.RoomId == roomId, trackChanges).OrderBy(k => k.ShopItemName)
 .Skip((shopItemParameters.PageNumber - 1) * shopItemParameters.PageSize).Take(shopItemParameters.PageSize).ToListAsync();

            return PagedList<ShopItem>.ToPagedList(shopItems, shopItemParameters.PageNumber, shopItemParameters.PageSize);


        }
    }

}
