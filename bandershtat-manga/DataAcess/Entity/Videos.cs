using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public class Videos
    {
        public int Id { get; set; }
        public string FileName { get; set; }

        public ICollection<VideosGanr> Ganrs { get; set; } = new HashSet<VideosGanr>();
    }
}
