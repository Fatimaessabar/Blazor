using Blazor.Server.DATA;
using Blazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<User>>> GetUsers()
        {
            var Users = await _context.Users.ToListAsync();
            return new ServiceResponse<List<User>>
            {
                Data = Users
            };
        }
    }
}
