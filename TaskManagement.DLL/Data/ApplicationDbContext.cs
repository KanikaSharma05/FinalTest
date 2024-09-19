using Microsoft.EntityFrameworkCore;
using System.Drawing;
using TaskManagement.DLL.Entity;

namespace TaskManagement.DLL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var managerId = 1;
            var employeeId = 2;


            modelBuilder.Entity<User>().HasData(
                new User { UserId = managerId, Name = "Kanika Sharma", Email = "kanika@gmail.com", PhoneNumber = "7845968574", Password = "Admin@123", ConfirmPassword = "Admin@123" },
                new User { UserId = employeeId, Name = "John", Email = "john@gmail.com", PhoneNumber = "7845918574", Password = "John@123", ConfirmPassword = "John@123" });

            var managerRoleId = 1;
            var employeeRoleId = 2;

             modelBuilder.Entity<Role>().HasData(
            new Role { RoleId = managerRoleId, RoleName = "Manager", UserId = managerId },
            new Role { RoleId = employeeRoleId, RoleName = "Employee", UserId = employeeId, });


            modelBuilder.Entity<UserRole>().HasData(
                new UserRole {Id=1, UserId = managerId,RoleId= managerRoleId },
                new UserRole {Id=2, UserId = employeeId,RoleId= employeeRoleId });

        }
    }
}
