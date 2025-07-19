using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repo
{
  public interface IRoomRepo
    {
       Task<IEnumerable<Room>>GetAllRooms(bool trackChanges);
       Task< Room> FindRoom(int id,bool trackChanges);
        void CreateRoom(Room room);
    }
}
