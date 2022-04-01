using Microsoft.AspNetCore.Identity;

namespace Yousif_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

    }
}
