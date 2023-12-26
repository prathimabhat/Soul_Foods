using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soul_Foods.Models
{
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CategoryName { get; set; }

        //Foreign key to Restaurant table
        // 1 category can belong to 1 restaurant but 1 restaurant can have multiple categories. 1 to n relationship
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        //Relationship between item and category
        public List<Item> Items { get; set; }
    }
}
