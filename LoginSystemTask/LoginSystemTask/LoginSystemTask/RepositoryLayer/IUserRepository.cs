using LoginSystemTask.Models;

namespace LoginSystemTask.RepositoryLayer
{
    public interface IUserRepository
    {
        User GetUser(string username, string password);
        void AddUser(User user);
        User GetUserByEmail(string email);
    }
}
