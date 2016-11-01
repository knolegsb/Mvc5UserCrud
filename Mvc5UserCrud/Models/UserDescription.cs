using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc5UserCrud.Models
{
    public class UserDescription
    {
        [Key, ForeignKey("User")]
        public string UserId { get; set; }

        public string Description { get; set; }

        public User User { get; set; }
    }
}