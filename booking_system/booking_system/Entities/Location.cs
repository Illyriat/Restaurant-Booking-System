using System.ComponentModel.DataAnnotations;


namespace booking_system.Entities
{
    public class Location
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]  
        [MaxLength(25)]
        public string PostCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        public bool Deleted { get; set; }



        public ICollection<Table> Tables { get;  }
    }
}