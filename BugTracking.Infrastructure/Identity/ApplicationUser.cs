using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking.Infrastructure.Identity
{
    //instance for application user
    public sealed class ApplicationUser : IdentityUser
    {
        public bool EnableNotifications { get; set; }
        public string Initials { get; set; } = string.Empty;

    }
}
