using BHAMCApp.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class RoleEdit
    {
        
            public IdentityRole RoleName { get; set; }
            public IEnumerable<ApplicationUser> MemberToRole { get; set; }
            public IEnumerable<ApplicationUser> NotMembersToRole { get; set; }
        
    }
}
