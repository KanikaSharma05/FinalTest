using System.ComponentModel.DataAnnotations;

namespace TaskManagement.DLL.Entity
{
    public class Tasks
    {
       

        [Key]
        public int TaskId {  get; set; }

        [Required(ErrorMessage ="**Required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Title Can't Be less than 2 Chacters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters only")]
        public string Title { get; set; }

        [Required(ErrorMessage = "**Required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Title Can't Be less than 2 Chacters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters only")]
        public string Description { get; set; }

        [Required(ErrorMessage ="**Required")]
        public List<string> Assignee { get; set; }

        [Required(ErrorMessage ="**Required")]
        [DataType(DataType.Date)]
        public DateTime? Deadline { get; set; }

        [Required(ErrorMessage = "**Required")]
        public List<string> Priority { get; set; }

        [Required(ErrorMessage = "**Required")]
        public List<string> Status { get; set; }

    }
}
