using TaskManagement.DLL.Entity;

namespace TaskManagement.DLL.IRepository
{
    public interface IUserRoleRepository
    {
        Task AddUserRole(string userId, string roleId);
        Task<List<UserRole>> GetAllRoles();
        Task<List<UserRole>> GetRoleByUserId(string userId);
        Task<List<UserRole>> GetByRoleId(string roleId);

    }
}
