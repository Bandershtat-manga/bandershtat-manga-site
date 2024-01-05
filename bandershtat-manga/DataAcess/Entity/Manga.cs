using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public class Manga
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string NamePerecladachs { set; get; }
        public string NameAutor { set; get; }
        public DateTime datePublish { set; get; }
        public string yearLimit { set; get; }
        public DateTime yearCreate { set; get; }
        public ICollection<MangaGanr> Ganrs { get; set; } = new HashSet<MangaGanr>();
        public List<string> fileNames = new List<string>();

    }
}
