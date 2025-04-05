using System.ComponentModel.DataAnnotations;

namespace CarRental.DataAccess.Entities
{
    public class EntityBase
    {
        [Key]
        [Required]
        public int Id { get; set; }

    }
}
