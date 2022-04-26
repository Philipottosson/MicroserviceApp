
using Microsoft.EntityFrameworkCore;

namespace GameService.DAL
{
    public class GameHandler 
    {
        private readonly GameContext _context;

        public GameHandler(GameContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Games>> GetAllGamesAsync()
        {
            return await _context.Users.ToListAsync();
        }



        public async Task PostGameAsync(string name, string publisher, string contactInfo)
        {

            Games game = new Games();
            game.Name = name;
            game.Publisher = publisher;
            game.ContactInfo = contactInfo;
            _context.Users.Add(game);
            await _context.SaveChangesAsync();
            return;
        }
    }
}
