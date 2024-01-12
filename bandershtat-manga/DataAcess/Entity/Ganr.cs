using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Entity
{
    public enum Ganrs : int
    {
        Kodomo = 1,
        Shoujo,
        Shounen,
        Seinen,
        Josei,
        MahoShounen,
        MahoShoujo,
        ShoujoAi,
        Yuri,
        ShounenAi,
        Yaoi,
        Harem,
        Shotacon,
        Mecha,
        Scifi,
        Cyberpunk,
        Steampunk,
        Apocalypse,
        Postapocalypse,
        Fantasy,
        Horror,
        Gothic,
        Western,
        Adventure,
        SchoolLife,
        Boyovuk,
        Detektuv,
        Drama,
        History,
        Comedy,
        Romantic,
        Hentai
    }

    public class Ganr
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }
        public ICollection<MangaGanr> Mangas { get; set; } = new HashSet<MangaGanr>();
    }
}
