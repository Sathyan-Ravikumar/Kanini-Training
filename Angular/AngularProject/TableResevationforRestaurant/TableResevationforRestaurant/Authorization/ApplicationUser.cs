using Microsoft.AspNetCore.Identity;

namespace TableResevationforRestaurant.Authorization
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
