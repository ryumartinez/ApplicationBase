using Accessors.Dtos;
using Accessors.Interfaces;

namespace Accessors;

public class UserDataAccess : IUserDataAccess
{
    public Task<IEnumerable<UserAccessModel>> GetUserListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserAccessModel> GetUserByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserAccessModel> CreateUserAsync(CreateUserAccessRequest createUserAccessRequest)
    {
        throw new NotImplementedException();
    }

    public Task<UserAccessModel> UpdateUserAsync(UpdateUserAccessRequest updateUserAccessRequest)
    {
        throw new NotImplementedException();
    }

    public Task<UserAccessModel> DeleteUserAsync(int id)
    {
        throw new NotImplementedException();
    }
}