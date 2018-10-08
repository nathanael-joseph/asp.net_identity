using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treehouse.FitnessFrog.Shared.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Treehouse.FitnessFrog.Shared.Security
{
    public class ApplicationSignInManager : SignInManager<User, string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager) 
            : base(userManager, authenticationManager)
        {

        }
    }
}
