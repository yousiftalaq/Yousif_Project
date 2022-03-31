using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Yousif_Project.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "Display Order for Category must be Greater then 0!")]
        public int DisplayOrder { get; set; }
    }
}
