using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace booking_system.Entities
{
    public class Table
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int TableNumber { get; set; }

        [Required]
        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }

        public Location Location { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }
    }
}

