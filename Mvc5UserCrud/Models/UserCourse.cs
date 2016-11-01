using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc5UserCrud.Models
{
    public class UserCourse
    {
        [Key]
        public string UserCourseId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public string CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public bool Checked { get; set; }
    }
}