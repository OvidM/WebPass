using System.Collections.Generic;

namespace EDataAccessLibrary.Models
{
    public class UserModel
    {
        public int Id {get; set;}
        public string UserName {get; set; }
        public string PassWord {get; set; }
        public string PassKey {get; set;}
        public string PassIV {get; set;}
        public string RepeatPassWord {get; set;}
    }
}