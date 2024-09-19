using TaskManagement.DLL.Entity;

namespace TaskManagement.DLL.IRepository
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
        Task<User>GetAllUser();
        Task<User> GetUserById(int id);
        Task<User> GetUserByName(string name);
        Task<User> GetUserByEmail(string email);

    }
}
