using Microsoft.AspNetCore.Identity;
using Server.Data;

namespace Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
