using AutoMapper;
using Contracts;
using Contracts.Repo;
using Contracts.Service;
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
        public IEnumerable<RoomDto> GetAllRoomsService(bool tracking)
        {

            var rooms = _repoManager.RoomRepo.GetAllRooms(tracking);
                var roomsDto = _mapper.Map<IEnumerable<RoomDto>>(rooms);
                return roomsDto;     
            
        }
    }
}
