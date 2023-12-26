using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soul_Foods.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Ingrdients { get; set; }

        //Foreign key to Categories table
        //public virtual Categories Category { get; set; }

        ////foreign key to Restaurant tabl
        //[Required]
        //public virtual Restaurant Restaurant { get; set; }
    }
}
