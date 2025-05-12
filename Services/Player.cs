using Microsoft.EntityFrameworkCore;
using SimpleAPI.Entity;
using SimpleAPI.Model;

namespace SimpleAPI.Services
{
    public class PlayerService
    {
        private readonly APIDbContext _context;

        public PlayerService(APIDbContext context)
        {
            _context = context;
        }

        public async Task<Player> GetPlayerInfoAsync(string username)
        {
            if (_context == null)
            {
                throw new InvalidOperationException("Контекст базы данных не инициализирован.");
            }

            var player = await _context.Players
                .FirstOrDefaultAsync(player => player.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (player == null)
            {
                // Можно вернуть null или создать исключение, если нужно
                return null;  // или сделать исключение, например:
                              // throw new KeyNotFoundException($"Игрок с ником {username} не существует!");
            }

            return player;
        }

    }
}
