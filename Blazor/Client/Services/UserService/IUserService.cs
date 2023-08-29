using Blazor.Shared;

namespace Blazor.Client.Services.UserService
{
    public interface IUserService
    {
        public Task<List<User>> GetUsers();

    }
}
