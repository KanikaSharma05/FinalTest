using TaskManagement.DLL.Entity;

namespace TaskManagement.DLL.IRepository
{
    public interface ITaskRepository
    {
        Task AddTask (Tasks task);
        Task UpdateTask (Tasks task);
        Task DeleteTask (Tasks task);
        Task<List<Tasks>> GetAllTasks();
        Task<List<Tasks>> GetAll(string? search, string? sort, bool isAsc,int pageNumber,int pageSize);
        Task<List<Tasks>> GetAlltask(string? search, string? sort, bool isAsc);
        Task<List<Tasks>> GetAllTasksPage(int pageNumber, int pageSize);
        Task<Tasks> DeleteTaskById(int id);
        Task<Tasks> GetTaskById(int id);


    }
}
