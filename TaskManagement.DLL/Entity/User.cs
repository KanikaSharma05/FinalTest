using System.ComponentModel.DataAnnotations;

namespace TaskManagement.DLL.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "**Required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name Can't Be less than 2 Chacters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please Enter Characters only")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "**Required")]
        [StringLength(100)]
        [RegularExpression(@"^[A-Za-z\._\-0-9]*[@][A-Za-z]*[\.][a-z]{2,4}$", ErrorMessage = "Please Enter Valid Proper Email Structure")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "**Required")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Please Enter Valid 10 digit indian Number Starting with 6-9")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "This Feild is Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Make your Password Strong by using Lower case,Upper Case,Special Characters and digit")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "This Feild is Required")]
        [Compare("Password", ErrorMessage = "Password Does not Match")]
        public string ConfirmPassword { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
    }
}
