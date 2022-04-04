using Microsoft.AspNetCore.Identity;

namespace Yousif_Models.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

    }
}
