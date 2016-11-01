using System.Collections.Generic;

namespace Mvc5UserCrud.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Checked { get; set; }
        public IList<UserCourse> UserCourses { get; set; }
    }
}