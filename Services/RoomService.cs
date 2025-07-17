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
    internal sealed class RoomService:IRoomService
    {
        private readonly ILogger _logger;
        private readonly IRepositoryManager _repoManager;
        public RoomService(ILogger logger, IRepositoryManager repository)
        {
            _logger = logger;
            _repoManager = repository;
        }
    }
}
