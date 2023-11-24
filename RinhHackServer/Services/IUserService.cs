using RinhHackServer.Models;

namespace RinhHackServer.Services
{
    public interface IUserService
    {
        bool IsValidUserInformation(UserModel model);
        UserModel GetUserDetails();
    }
}