using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.DLL.Entity;

namespace TaskManagment.BLL.DTOs
{
    public class RoleVM
    {
       
        public int? RoleId { get; set; }
        public string? RoleName { get; set; } = "Employee";

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
