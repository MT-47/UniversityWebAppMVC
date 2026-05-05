namespace UniversityWebApp.Models
{
    public class StudentBL
    {
        List<Student> students;

        public StudentBL()
        {
            students = new List<Student>();

            students.Add(new Student { Id = 1, Name = "Alice", Age = 20, Email = "Alice@mail.com", ImageUrl = "alice.jpg" });
            students.Add(new Student { Id = 2, Name = "Bob", Age = 22, Email = "Bob@mail.com", ImageUrl = "bob.jpg" });
            students.Add(new Student { Id = 3, Name = "Ema", Age = 21, Email = "Ema@mail.com", ImageUrl = "ema.jpg" });
            students.Add(new Student { Id = 4, Name = "David", Age = 23, Email = "David@mail.com", ImageUrl = "david.jpg" });

        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
