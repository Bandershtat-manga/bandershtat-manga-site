using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public class User : IdentityUser
    {
        public List<Videos> savedVideos = new List<Videos>();
        public List<SaveManga> saveMangas = new List<SaveManga>();
    }
}
