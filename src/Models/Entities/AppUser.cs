
using Microsoft.AspNetCore.Identity;

namespace AngularASPNETCore2WebApiAuth.Models.Entities
{
    // Add profile data for application users by adding properties to this class
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public bool ReceiveNotifications { get; set; }
        public bool PoliciesAccepted { get; set; }
        public long? FacebookId
        {
            get; set;
        }
    }
}
