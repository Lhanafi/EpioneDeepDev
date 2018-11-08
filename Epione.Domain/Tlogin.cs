using Microsoft.AspNet.Identity.EntityFramework;

namespace Epione.Domain
{
    public class Tlogin :IdentityUserLogin<int>
    {
        public int Id { get; set; }
    }
}