using System.Collections.Generic;

namespace WebAppAuth.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}
