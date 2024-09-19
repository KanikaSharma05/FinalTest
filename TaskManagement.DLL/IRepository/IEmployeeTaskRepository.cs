using TaskManagement.DLL.Entity;

namespace TaskManagement.DLL.IRepository
{
    public interface IEmployeeTaskRepository
    {
        Task<EmployeeTask> GetTaskById(int TaskId);
        Task<EmployeeTask> GetTaskByName(string Name);
        Task UpdateTask (EmployeeTask employeeTask);
        Task<EmployeeTask> GetTaskByStatus(string status);
    }
}
