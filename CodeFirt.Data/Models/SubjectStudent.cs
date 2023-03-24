

namespace CodeFirt.Data.Models
{
    public class SubjectStudent
    {
        public int Id { get; set; }
        public List<Subject>? Subject { get; set; }
        public int SubjectId { get; set; }
        public List<Student> Student { get; set; }
        public int StudentId { get; set; }
        
    }
}
