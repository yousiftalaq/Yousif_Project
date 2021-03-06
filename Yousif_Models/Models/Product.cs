using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yousif_Models.Models
{
    public class Product
    {

        public Product()
        {
            TempSqft = 1;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public string ShortDesc { get; set; }

        public string Description { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="Price Must Be Greater Then 0!")]
        public double Price { get; set; }

        public string Image { get;  set; }

        [Display(Name ="Category Type")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public virtual Category Category { get; set; } 

        [Display(Name ="Application Type")]

        public int ApplicationTypeId { get; set; } 

        [ForeignKey("ApplicationTypeId")]
        public virtual ApplicationType ApplicationType { get; set; }

        [Range(1,10000)]
        [NotMapped]
        public int TempSqft { get; set; }

    }
}
