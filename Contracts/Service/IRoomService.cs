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
       Task< IEnumerable<RoomDto>> GetAllRoomsService(bool trackChanges);
       Task<RoomDto> FindRoomsService(int id,bool trackChanges);
         Task<RoomDto> AddRoom(NewRoomDto roomdto);



    }
}
