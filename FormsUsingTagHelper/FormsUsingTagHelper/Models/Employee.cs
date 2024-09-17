namespace FormsUsingTagHelper.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }    // Creating drop down using Enum(Collection of constant)   
        public string Married { get; set; }
        public string Description { get; set; }
    }
    public enum Gender
    {
        Male,Female
    }
}
