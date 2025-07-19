using Contracts.Repo;
using Entities.Models;
using Repository.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public sealed class RoomRepo:RepositoryBase<Room>,IRoomRepo
    {
        public RoomRepo(ApplicationDbContext context): base(context)
        {
          
        }
        public IEnumerable<Room> GetAllRooms(bool tracking) => [.. FindAll(tracking).OrderBy(k=>k.RoomOwner)];
        public Room FindRoom(int id, bool trackChanges)
        {
            var room = FindByCondition((k=>k.RoomId.Equals(id)),trackChanges);
            return room.FirstOrDefault();
        }
        public void CreateRoom(Room room)=>CreateBase(room);


    }
}
