using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override string UserName { get; set; }
    }
}