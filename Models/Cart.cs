using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soul_Foods.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }

        //public virtual ApplicationUser CartUser { get; set; }

        //public virtual Restaurant Restaurant { get; set; }
        //public virtual ICollection<Item> Items { get; }
    }
}
