using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public class MangaGanr
    {
        public int MangaId { get; set; }
        public int GanrId { get; set; }

        public virtual Manga Manga { get; set; }
        public virtual Ganr Ganr { get; set; }
    }
}
