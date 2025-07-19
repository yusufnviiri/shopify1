using Contracts.Repo;
using Microsoft.EntityFrameworkCore;
using Repository.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IRoomRepo> _roomRepo;
        private readonly Lazy<IShopItemRepo> _shopItemRepo;
        private readonly ApplicationDbContext _dbContext;
        public RepositoryManager(ApplicationDbContext dbContext)
        {
            _roomRepo = new Lazy<IRoomRepo>(() => new RoomRepo(dbContext));
            _shopItemRepo = new Lazy<IShopItemRepo>(() => new ShopItemRepo(dbContext));

            _dbContext = dbContext;
        }
        public IRoomRepo RoomRepo => _roomRepo.Value;
        public IShopItemRepo ShopItemRepo => _shopItemRepo.Value;
        public async Task SaveRepoDataAsync()=> await _dbContext.SaveChangesAsync();
        //public async Task SaveAsync() { await _context.SaveChangesAsync(); }


    }
}
