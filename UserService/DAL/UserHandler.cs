
using Microsoft.EntityFrameworkCore;

namespace UserService.DAL
{
    public class UserHandler 
    {
        private readonly UserContext _context;

        public UserHandler(UserContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Users>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }



        public async Task PostUserAsync(string firstName, string lastName, string email)
        {

            Users user = new Users();
            user.Email = email;
            user.FirstName = firstName;
            user.LastName = lastName;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return;
        }
    }
}
