using System.ComponentModel.DataAnnotations;

namespace TaskManagment.BLL.DTOs
{
    public class UserVM
    {
        public int UserId { get; set; }

        public string? Name { get; set; }

       
        public string? Email { get; set; }

     
        public string? PhoneNumber { get; set; }
      
        public string? Password { get; set; }

    
        public string? ConfirmPassword { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
    }
}
