using AutoMapper;
using Contracts;
using Contracts.Repo;
using Contracts.Service;
using Entities.Exceptions;
using Entities.Models;
using NLog;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   internal sealed class ShopItemService:IShopItemService
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repoManager;
        private readonly IMapper _mapper;

        public ShopItemService(ILoggerManager logger, IRepositoryManager repository, IMapper mapper)
        {
            _logger = logger;
            _repoManager = repository;
            _mapper = mapper;
        }
        public IEnumerable<ShopItemDto> GetAllShopItemsService(bool tracking)
        {

            var items = _repoManager.ShopItemRepo.GetAllShopItems(tracking);
            var itemsDto = _mapper.Map<IEnumerable<ShopItemDto>>(items);
            return itemsDto;

        }
        public ShopItemDto FindShopItemService(int id, bool trackChanges)
        {
            var item = _repoManager.ShopItemRepo.FindShopItem(id, trackChanges) ?? throw new ShopItemNotFoundException(id);
            var itemDto = _mapper.Map<ShopItemDto>(item);
            return itemDto;
        }
        public ShopItemDto FindRoomShopItemService(int id,int roomId, bool trackChanges)
        {
            var item = _repoManager.ShopItemRepo.FindRoomShopItem(id,roomId, trackChanges) ?? throw new ShopItemNotFoundException(id);
            var itemDto = _mapper.Map<ShopItemDto>(item);
            return itemDto;
        }
        public async Task<ShopItemDto> AddShopItem(NewShopItemDto itemdto)
        {
            var itemEntity = _mapper.Map<ShopItem>(itemdto);
            _repoManager.ShopItemRepo.CreateShopItem(itemEntity);
            await _repoManager.SaveRepoDataAsync();
            var itemToReturn = _mapper.Map<ShopItemDto>(itemEntity);
            return itemToReturn;
        }

    }
}
