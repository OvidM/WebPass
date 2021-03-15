using System.ComponentModel.DataAnnotations;

namespace WebPassManager.Models
{
    public class DisplayRegisterUserModel
    {
        public int Id {get; set;}
        [Required]
        [MinLength(5, ErrorMessage = "Minimum 5 characters")]
        public string UserName {get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Minimum 8 characters")]
        [DataType(DataType.Password)]
        public string PassWord {get; set; }
        [Required]
        [Compare(nameof(PassWord), ErrorMessage = "Passwords must match")]
        public string RepeatPassWord {get; set;}
    }
}