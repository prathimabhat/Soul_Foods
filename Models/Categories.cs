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
        //public virtual Restaurant Restaurant { get; set; }
    }
}
