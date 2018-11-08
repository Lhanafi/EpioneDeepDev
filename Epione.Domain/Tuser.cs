using Microsoft.AspNet.Identity.EntityFramework;

namespace Epione.Domain
{
    public class Tuser :IdentityRole<int,Trole>
    {
        public Tuser() { }
    
        public Tuser(string name) { Name = name; }
    }
}