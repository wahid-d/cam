using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using cam.Data;
using cam.Models;
using Microsoft.EntityFrameworkCore;

namespace cam.Services
{
    public class ClassService : IClassService
    {
        private readonly ApplicationDbContext _context;

        public ClassService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Class>> Get()
        {
            return await _context.Classes.ToListAsync();
        }
        public async Task<Class> Get(string id)
        {
            return await _context.Classes.Where(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task<List<Class>> GetForRoom(string roomId)
        {
            return await _context.Classes.Where(c => c.RoomId == roomId).ToListAsync();
        }

        public async Task<Class> Insert(Class @class)
        {
            await _context.Classes.AddAsync(@class);
            await _context.SaveChangesAsync();

            return @class;
        }

        public async Task<Class> Update(Class @class)
        {
            var c = await _context.Classes.Where(c => c.Id == @class.Id).FirstOrDefaultAsync();
            c.RoomId = @class.RoomId;
            _context.Classes.Update(c);
            await _context.SaveChangesAsync();
            return c;
        }

        public async Task<Class> Remove(Class @class)
        {
            var result = _context.Classes.Remove(@class);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

    }

    public interface IClassService
    {
        Task<List<Class>> Get();
        Task<Class> Get(string id);
        Task<List<Class>> GetForRoom(string roomId);
        Task<Class> Insert(Class @class);

        Task<Class> Update(Class @class);
        Task<Class> Remove(Class @class);
    }
}