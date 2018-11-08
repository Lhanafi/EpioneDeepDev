using Microsoft.AspNet.Identity.EntityFramework;

namespace Epione.Domain
{
    public class Tclaim :IdentityUserClaim<int>
    {
        public int Id { get; set; }
    }
}