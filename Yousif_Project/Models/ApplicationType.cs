using System.ComponentModel.DataAnnotations;

namespace Yousif_Project.Models
{
    public class ApplicationType
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        
    }
}
