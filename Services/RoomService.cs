using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using cam.Data;
using cam.Models;
using Microsoft.EntityFrameworkCore;

namespace cam.Services
{
    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Room>> Get()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> Get(string id)
        {
            return await _context.Rooms.Where(r => r.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Room> Insert(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();

            return room;
        }
    }

    public interface IRoomService
    {
        Task<List<Room>> Get();
        Task<Room> Get(string id);
        Task<Room> Insert(Room student);
    }
}