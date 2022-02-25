using System.ComponentModel.DataAnnotations;

namespace Document_Saver.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
       
        public string User_Name { get; set; }
       
        public string User_Email { get; set; }
        
        public string User_Password { get; set; }

        public int User_Phone { get; set; } = 0;
        public string User_Emp_Id { get; set; } = "";

        public string User_Image { get; set; } = "";

        public DateTime Created_At { get; set; } = DateTime.Now;
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public string Created_By { get; set; } = "";
        public string Updated_By { get; set; } = "";
        public int OTP { get; set; } = 0;

    }
}
