using AutoMapper;
using TaskManagement.DLL.Entity;
using TaskManagment.BLL.DTOs;

namespace TaskManagment.BLL.MapperClass
{
    public class TaskManagmentMapperClass:Profile
    {
        public TaskManagmentMapperClass()
        {
            CreateMap<EmployeeTask, EmployeeTaskVM>().ReverseMap();
            CreateMap<Role,RoleVM>().ReverseMap();   
            CreateMap<Task, TaskVM>().ReverseMap();
            CreateMap<User, UserVM>().ReverseMap();
            CreateMap<UserRole,UserRoleVM>().ReverseMap();
        }
    }
}
