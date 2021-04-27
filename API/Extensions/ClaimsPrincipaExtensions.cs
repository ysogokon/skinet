using System.Linq;
using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipaExtensions
    {
        public static string ReturnEmailFromPrincipal(this ClaimsPrincipal user)
        {
            // these below are equally return the same value
            //return user?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            return user.FindFirstValue(ClaimTypes.Email);
        }
    }
}