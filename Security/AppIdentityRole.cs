using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WAD_Assignment1.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string RoleDescription { get; set; }

    }
}
