using Microsoft.AspNetCore.Identity;

namespace WhiteLagoon.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = null!;
        public DateTime CreateAt { get; set; }
    }
}
