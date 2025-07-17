using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
    public interface IServiceManager
    {
        public IRoomService RoomService { get; }
        public IShopItemService ShopItemService { get; }

    }
}
