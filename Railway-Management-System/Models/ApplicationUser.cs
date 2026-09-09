using Microsoft.AspNetCore.Identity;

namespace Railway_Management_System.Models;

public class ApplicationUser: IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}