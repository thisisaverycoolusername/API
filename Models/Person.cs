using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
       
        public string? PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public IEnumerable<PersonWithInterests>? Interests { get; set; }
    }
}
