using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public enum TypesD : int
    {
        Admin = 1,
        Client
    }

    public class Roles : IdentityRole
    {
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
