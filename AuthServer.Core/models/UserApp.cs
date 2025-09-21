using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthServer.Core.models
{
    public class UserApp: IdentityUser
    {
        public string City { get; set; }

    }
}
