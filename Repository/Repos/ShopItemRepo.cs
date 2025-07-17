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
    internal class ShopItemRepo : RepositoryBase<Room>, IShopItemRepo
    {
        public ShopItemRepo(ApplicationDbContext context) : base(context)
        {

        }
    }
   
}
