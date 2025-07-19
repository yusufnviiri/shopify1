using Entities.Models;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Service
{
    public interface IRoomService
    {
        IEnumerable<RoomDto> GetAllRoomsService(bool trackChanges);
        RoomDto FindRoomsService(int id,bool trackChanges);
         Task<RoomDto> AddRoom(NewRoomDto roomdto);



    }
}
