using Contracts.Repo;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Room>> GetAllRooms(bool tracking) =>await FindAll(tracking).OrderBy(k=>k.RoomOwner).ToListAsync();
        public async Task<Room> FindRoom(int id, bool trackChanges)
        {
            var room =await FindByCondition((k=>k.RoomId.Equals(id)),trackChanges).ToListAsync();
            return room.FirstOrDefault();
        }
        public void CreateRoom(Room room)=>CreateBase(room);


    }
}
