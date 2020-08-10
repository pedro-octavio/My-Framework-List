using System.ComponentModel.DataAnnotations;

namespace MyFrameworkList.Domain.Entities
{
    public class Framework
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        public int LanguageId { get; set; }
    }
}
