using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repo
{
   public interface IRepositoryManager
    {
        public IRoomRepo RoomRepo { get; }
        public IShopItemRepo ShopItemRepo { get; }
        Task SaveRepoDataAsync();
    }
}
