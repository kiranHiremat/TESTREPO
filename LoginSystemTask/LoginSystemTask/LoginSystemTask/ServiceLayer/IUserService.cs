using LoginSystemTask.Models;

namespace LoginSystemTask.ServiceLayer
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        void Register(User user);
        User ResetPassword(string email);
    }
}
