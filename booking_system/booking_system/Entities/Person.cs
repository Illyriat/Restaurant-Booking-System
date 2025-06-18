using System.ComponentModel.DataAnnotations;

namespace booking_system.Entities
{
    public class Person
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required] 
        public string FirstName { get ; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool Deleted { get; set; }
    }
}
