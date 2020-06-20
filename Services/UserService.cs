using System.Collections.Generic;
using System.Threading.Tasks;
using cam.Data;
using Microsoft.EntityFrameworkCore;

namespace cam.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<AppUser>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        // public async Task<AppUser> Insert(AppUser AppUser)
        // {
   
        //     return AppUser;
        // }
    }

    public interface IUserService
    {
        Task<List<AppUser>> Get();
        // Task<AppUser> Get(int id);
        // Task<AppUser> Insert(AppUser AppUser);
        // Task<AppUser> Update(ToDo toDo);
        // Task<AppUser> Delete(int id);
    }
}