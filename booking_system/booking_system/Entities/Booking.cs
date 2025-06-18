using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace booking_system.Entities
{
    public class Booking
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [ForeignKey(nameof(Table))]
        public int TableId { get; set; }
        public Table Table { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }

        [Required]
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Deleted { get; set; }



        public ICollection<Table> Tables { get; set; }
    }
}
