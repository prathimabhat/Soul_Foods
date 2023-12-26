using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soul_Foods.Models
{
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantDescription { get; set; }

        //Relationship betwwen restaurant and categories
        public List<Categories> Categories { get; set; }

        //Relationship between restaurant and items
        public List<Item> Items {  get; set; }
    }
}
