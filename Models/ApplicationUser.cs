using Microsoft.AspNetCore.Identity;

namespace Soul_Foods.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }

       
    }
}
