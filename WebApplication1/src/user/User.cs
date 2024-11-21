using Microsoft.AspNetCore.Identity;

namespace WebApplication1.user;

public class User : IdentityUser
{
    public string? Initials { get; set; }
}
