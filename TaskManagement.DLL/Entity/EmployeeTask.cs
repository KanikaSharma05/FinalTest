using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.DLL.Entity
{
    public class EmployeeTask
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User? User { get; set; }

        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public virtual Tasks? Task { get; set; }
    }
}
