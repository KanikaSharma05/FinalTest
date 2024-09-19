using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.DLL.Entity;

namespace TaskManagment.BLL.DTOs
{
    public class UserRoleVM
    {
    
        public int? Id { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey("Role")]

        public int? RoleId { get; set; }
        public virtual Role? Role { get; set; }
    }
}
