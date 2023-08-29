using Blazor.Shared;

namespace Blazor.Server.Services.UserService
{
    public interface IUserService
    {
        public Task<ServiceResponse<List<User>>>  GetUsers();

    }
}
