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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Services
{
    internal sealed class RoomService:IRoomService
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repoManager;
        private readonly IMapper _mapper;

        public RoomService(ILoggerManager logger, IRepositoryManager repository, IMapper mapper)
        {
            _logger = logger;
            _repoManager = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<RoomDto>> GetAllRoomsService(bool tracking)
        {

            var rooms =await _repoManager.RoomRepo.GetAllRooms(tracking);
                var roomsDto = _mapper.Map<IEnumerable<RoomDto>>(rooms);
                return roomsDto;     
            
        }
        public async Task<RoomDto> FindRoomsService(int id, bool trackChanges)
        {
                  var room = await _repoManager.RoomRepo.FindRoom(id,trackChanges);
            if (room is null)
                throw new RoomNotFoundException(id);

            var roomDto = _mapper.Map<RoomDto>(room);
                return roomDto; 
        }
        public async Task<RoomDto> AddRoom(NewRoomDto roomdto)
        {
            var roomEntity = _mapper.Map<Room>(roomdto);
            _repoManager.RoomRepo.CreateRoom(roomEntity);
          await  _repoManager.SaveRepoDataAsync();
            var roomToReturn = _mapper.Map<RoomDto>(roomEntity);
            return roomToReturn;
        }

    }
}
