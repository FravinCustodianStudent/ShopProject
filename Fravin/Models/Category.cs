using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fravin.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Omg...Order cannot be lower than 10")]
        public int DisplayOrder { get; set; }
    }
}
