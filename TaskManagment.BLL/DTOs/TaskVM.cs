namespace TaskManagment.BLL.DTOs
{
    public class TaskVM
    {

        public int? TaskId { get; set; }


        public string? Title { get; set; }


        public string? Description { get; set; }


        public List<string>? Assignee { get; set; }


        public DateTime? Deadline { get; set; }


        public List<string>? Priority { get; set; }


        public List<string>? Status { get; set; }

    }
}
