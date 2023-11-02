using Angular2.Data;
using Angular2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular2.Services
{
    public class PlayersService : IPlayersService
    {
        private readonly FootballDbContext _context;

        public PlayersService(FootballDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Players>> GetPlayersList()
        {
            return await _context.Players
                .Include(x => x.Position)
                .ToListAsync();
        }

        public async Task<Players> GetPlayerById(int id)
        {
            return await _context.Players
                .Include(x => x.Position)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Players> CreatePlayer(Players player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }
        public async Task UpdatePlayer(Players player)
        {
            _context.Players.Update(player);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePlayer(Players player)
        {
            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
        }

        Task<Players> IPlayersService.CreatePlayer(Players player)
        {
            throw new NotImplementedException();
        }
    }
}
