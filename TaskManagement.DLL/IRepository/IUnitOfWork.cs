namespace TaskManagement.DLL.IRepository
{
    public interface IUnitOfWork
    {
        IEmployeeTaskRepository EmployeeTaskRepo { get; }
        IRoleRepository RoleRepo { get; }
        ITaskRepository TaskRepo { get; }
        IUserRepository UserRepo { get; }
        IUserRoleRepository UserRoleRepo { get; }
    }
}
