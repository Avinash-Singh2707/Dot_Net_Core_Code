using System.ComponentModel.DataAnnotations;

namespace ValidationAttribute.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is must")]
        //[StringLength(15,MinimumLength=3,ErrorMessage ="Name must be within 3 to 15 characters")]   //Set the limt of name is 15
        //[MaxLength(10)]    //
        [MinLength(3, ErrorMessage ="Minimum length must be 3 characters")]
        public string Name { get; set; }  // we can apply multiple attribute on single property

        [Required(ErrorMessage = "Email is must")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Age is must")] // Required is worked with null, if property get null, it will show ERROR MESSAGE
        [Range(5,18)]
        public int? Age { get; set; }  //it become nullabe integer, now it can hold null value,after adding "?"

        //[Required(ErrorMessage = "Password is must")]
        //[RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$" , ErrorMessage ="Contain Captial,Small,Symbol,Integer")]
        //public string password { get; set; }

        //[Required(ErrorMessage ="Confirm Password is must")]
        //[Compare("password", ErrorMessage ="Both password must be Identical")]
        //[Display(Name="Enter Confirm Password")]   // lable section will show here.....
        //public string confirmPassword { get; set; }

        //[Required(ErrorMessage ="URL is must")]
        //[Url(ErrorMessage="Invlaid URL")]
        //public string WebURL { get; set; }
    }
}
