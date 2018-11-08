using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity.EntityFramework.UserStore;
using Epione.Domain;
using System.Data.Entity;

namespace Epione.Data
{
    public class CustomUserStore : UserStore <User,Tuser,int,Tlogin,Trole,Tclaim>
    {
        public CustomUserStore(Context context) : base(context)
        {
        }
    }
}
