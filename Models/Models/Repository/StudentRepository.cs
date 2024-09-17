using Models.Models;

namespace Models.Repository
{
    public class StudentRepository : IStudent
    {
        public List<Student> getAllStudents()
        {
            return DataSource();
        }

        public Student getStudentById(int id)
        {
            //x is representing our student model.
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();    // Return that row -> FirstOrDefault();
            // Repository is called by our controller...
        }

        private List<Student> DataSource()
        {
            return new List<Student>    
            {
                new Student {rollNo=1,Name="Avi",Gender="Male",Standard=8},
                new Student {rollNo=2,Name="Avinash",Gender="Male",Standard=9},
                new Student {rollNo=3,Name="Singh",Gender="Male",Standard=1},
                new Student {rollNo=4,Name="Prem",Gender="Male",Standard=10},
                new Student {rollNo=5,Name="Nitya",Gender="Male",Standard=11}
            };
        }
    }
}
