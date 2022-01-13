using Microsoft.AspNetCore.Identity;

namespace Fravin.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
