namespace EDataAccessLibrary.Models
{
    public class PasswordModel
    {
        public int Id {get; set;}

        public string Service {get; set; }

        public string UserName {get; set; }

        public string PassWord {get; set; }
        public string RepeatPassWord {get; set;}
        public string PassKey {get; set;}
        public string PassIV {get; set;}
        public int UserId {get; set;}
    }
}