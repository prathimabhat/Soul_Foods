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
        // 1 item can belong to 1 category . But 1 category can have many items . 1: n relationship
        public int? CategoryId { get; set; }
        public virtual Categories Category { get; set; }

        ////foreign key to Restaurant table
        // 1 item can belong to 1 restaurant . But 1 restaurant can have multiple items in it's menu So 1 : n relationship
        //[Required]
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        //Foreign key to cart. Many items can be there in a cart and 1 item can belong to multiple carts at a point of time.
        // n : n relationship
        public List<Cart> Carts { get; set; }

    }
}
