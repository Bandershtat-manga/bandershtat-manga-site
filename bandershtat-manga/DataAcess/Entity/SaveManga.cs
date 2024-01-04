using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public class SaveManga
    {
        public Manga Manga { get; set;}
        public string SaveFileName { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
