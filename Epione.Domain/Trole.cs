using Microsoft.AspNet.Identity.EntityFramework;

namespace Epione.Domain
{
    public class Trole :IdentityUserRole<int>
    {
        public int Id { get; set; }
    }
}