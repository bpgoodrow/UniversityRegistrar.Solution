

using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<StudentCourse>();
    }

    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int CourseNumber { get; set; }

    public virtual ICollection<StudentCourse> JoinEntities { get;}
  }
}