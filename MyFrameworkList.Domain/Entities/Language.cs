using System.ComponentModel.DataAnnotations;

namespace MyFrameworkList.Domain.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
