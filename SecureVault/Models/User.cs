using Microsoft.AspNetCore.Identity;

namespace SecureVault.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}