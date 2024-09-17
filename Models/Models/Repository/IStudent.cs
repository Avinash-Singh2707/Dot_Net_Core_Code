using Models.Models;

namespace Models.Repository
{
    public interface IStudent
    {
        List<Student> getAllStudents();       // Defining Abstract Method   
        Student getStudentById(int id);  
    }
}
