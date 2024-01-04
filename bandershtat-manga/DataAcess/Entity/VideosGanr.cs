using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public class VideosGanr
    {
        public int VideosId { get; set; }
        public int GanrId { get; set; }

        public virtual Videos Videoses { get; set; }
        public virtual Ganr Ganr { get; set; }
    }
}
