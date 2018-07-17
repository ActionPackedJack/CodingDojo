
using System.ComponentModel.DataAnnotations;
namespace trails.Models
{
    public abstract class BaseEntity {}
    public class Trail: BaseEntity  

    {
        [Key]
        public long Id { get; set; }
 
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
 
        [Required]
        public int Length { get; set; }
 
        [Required]
        public int Elevation { get; set; }
    }
}