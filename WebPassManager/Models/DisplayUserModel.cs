using System.ComponentModel.DataAnnotations;

namespace WebPassManager.Models
{
    public class DisplayUserModel
    {
        public int Id {get; set;}
        [Required]
        public string UserName {get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PassWord {get; set; }
    }
}