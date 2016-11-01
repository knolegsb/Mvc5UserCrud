using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc5UserCrud.Models
{
    public class UserCountry
    {
        [Key]
        public string UserCountryId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public string CountryId { get; set; }

        [ForeignKey("CountryId")]
        public UserCountry Country { get; set; }
    }
}