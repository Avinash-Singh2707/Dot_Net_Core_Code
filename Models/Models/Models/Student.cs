namespace Models.Models
{
    public class Student
    {
        // Creating Model of Student 
        // To get and set the data -> the best practise is Repository patterns.
        // Using Home controller (In Index Method) we are generating data of student    
        public int rollNo { get; set; }
        public string Name  { get; set; }
        public string Gender { get; set; }
        public int Standard { get; set; }
    }
}
