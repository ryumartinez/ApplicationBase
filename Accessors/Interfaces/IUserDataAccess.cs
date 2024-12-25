using Accessors.Dtos;
using Accessors.Entities;

namespace Accessors.Interfaces;

public interface IUserDataAccess
{
    public Task<IEnumerable<UserAccessModel>> GetUserListAsync();
    public Task<UserAccessModel> GetUserByIdAsync(int id);
    public Task<UserAccessModel> CreateUserAsync(CreateUserAccessRequest createUserAccessRequest);
    public Task<UserAccessModel> UpdateUserAsync(UpdateUserAccessRequest updateUserAccessRequest);
    public Task<UserAccessModel> DeleteUserAsync(int id);
}