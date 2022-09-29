using Microsoft.AspNetCore.Identity;

namespace MvcBootstrap.App.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
