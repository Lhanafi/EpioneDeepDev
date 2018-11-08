using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
//using Epione.Domain.User;

namespace Epione.Domain
{
    public class User : IdentityUser<int,Tlogin,Trole,Tclaim>

    {
        public struct Adresse
        {
            public string street;
            public string city;
            public string postal_code;
            public string country;


        }
        [Key]
        [Required]
        public override int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Telephone { get; set; }
      
        public string address { get; set; }
        public string RoleUser { get; set; }



        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, int> manager)   
        {
        
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
   


}
//GHADA