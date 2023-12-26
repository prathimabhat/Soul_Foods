using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soul_Foods.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }

        //Foreign key to User table . 1 user can have 1 cart . 1:1 relationship
        //public int UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        //Foreign key to restaurant table 1 cart can belong to 1 restaurant at a point of time. It can be null when the cart is empty
        public int? RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        //Foreign key to cart. Many items can be there in a cart and 1 item can belong to multiple carts at a point of time.
        // n : n relationship
        public List<Item> Items { get; }
    }
}
