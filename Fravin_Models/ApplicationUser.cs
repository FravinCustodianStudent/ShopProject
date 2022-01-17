using Microsoft.AspNetCore.Identity;

namespace Fravin_Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
