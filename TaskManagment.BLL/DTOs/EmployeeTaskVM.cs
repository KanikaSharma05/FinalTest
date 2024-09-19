using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.DLL.Entity;

namespace TaskManagment.BLL.DTOs
{
    public class EmployeeTaskVM
    {
     
        public int? Id { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey("Task")]
        public int? TaskId { get; set; }
        public virtual Tasks? Task { get; set; }
    }
}
