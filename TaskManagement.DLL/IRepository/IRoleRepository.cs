using TaskManagement.DLL.Entity;

namespace TaskManagement.DLL.IRepository
{
    public interface IRoleRepository
    {
        Task AddRole(Role role);
        Task<Role> GetRole(string roleId);
        Task updateRole(Role role);

    }
}
