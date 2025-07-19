using Contracts;
using Contracts.Repo;
using Contracts.Service;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager:IServiceManager
    {
        private readonly Lazy<IRoomService> _roomService;
        private readonly Lazy<IShopItemService> _shopItem;
        public ServiceManager(ILoggerManager logger,IRepositoryManager repository)
        {
            _roomService = new Lazy<IRoomService>(()=>new RoomService(logger,repository));
            _shopItem = new Lazy<IShopItemService>(() => new ShopItemService(logger, repository));
                
        }   
        public IRoomService RoomService { get { return _roomService.Value; } }
        public IShopItemService ShopItemService { get { return _shopItem.Value; } }

    }
}
