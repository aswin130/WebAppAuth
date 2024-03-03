using System.Collections.Generic;

namespace WebAppAuth.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}