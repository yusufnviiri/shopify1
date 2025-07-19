using Contracts;
using Contracts.Repo;
using Contracts.Service;
using Entities.Models;
using NLog;
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
        public RoomService(ILoggerManager logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repoManager = repository;
        }
        public IEnumerable<Room> GetAllRoomsService(bool tracking)
        {
            try
            {
                var rooms = _repoManager.RoomRepo.GetAllRooms(tracking);
                return rooms;
            }
            catch (Exception ex) {

                _logger.LogError($"Something went wrong in {nameof(GetAllRoomsService)} service method {ex}");
                throw;
            }
        }
    }
}
