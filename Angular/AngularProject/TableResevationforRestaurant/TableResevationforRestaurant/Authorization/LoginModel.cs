using System.ComponentModel.DataAnnotations;

namespace TableResevationforRestaurant.Authorization
{
    public class LoginModel
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
