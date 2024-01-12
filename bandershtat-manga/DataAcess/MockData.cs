using DataAcess.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public static class MockData
    {
        public static void SeedGanrs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ganr>().HasData(new Ganr[]
            {
                new Ganr() { Id = (int)Ganrs.Adventure, Name = "Пригоди" },
                new Ganr() { Id = (int)Ganrs.Kodomo, Name = "Кодомо" },
                new Ganr() { Id = (int)Ganrs.Shoujo, Name = "Шьодзьо" },
                new Ganr() { Id = (int)Ganrs.Shounen, Name = "Шьонен" },
                new Ganr() { Id = (int)Ganrs.Seinen, Name = "Сейнен" },
                new Ganr() { Id = (int)Ganrs.Josei, Name = "Дзьосей" },
                new Ganr() { Id = (int)Ganrs.MahoShounen, Name = "Махо-шьонен" },
                new Ganr() { Id = (int)Ganrs.MahoShoujo, Name = "Шьоджьо-ай" },
                new Ganr() { Id = (int)Ganrs.ShoujoAi, Name = "Шьоджьо-ай" },
                new Ganr() { Id = (int)Ganrs.Yuri, Name = "Юрі" },
                new Ganr() { Id = (int)Ganrs.ShounenAi, Name = "Шьонен-ай" },
                new Ganr() { Id = (int)Ganrs.Yaoi, Name = "Яой" },
                new Ganr() { Id = (int)Ganrs.Harem, Name = "Гарем" },
                new Ganr() { Id = (int)Ganrs.Shotacon, Name = "Шьотакон" },
                new Ganr() { Id = (int)Ganrs.Mecha, Name = "Меха" },
                new Ganr() { Id = (int)Ganrs.Scifi, Name = "Наукова фантастика" },
                new Ganr() { Id = (int)Ganrs.Cyberpunk, Name = "Кіберпанк" },
                new Ganr() { Id = (int)Ganrs.Steampunk, Name = "Стімпанк" },
                new Ganr() { Id = (int)Ganrs.Apocalypse, Name = "Апокаліпсис" },
                new Ganr() { Id = (int)Ganrs.Postapocalypse, Name = "Постапокаліпсикс" },
                new Ganr() { Id = (int)Ganrs.Fantasy, Name = "Фентезі" },
                new Ganr() { Id = (int)Ganrs.Horror, Name = "Хоррор" },
                new Ganr() { Id = (int)Ganrs.Gothic, Name = "Готика" },
                new Ganr() { Id = (int)Ganrs.Western, Name = "Вестерн" },
                new Ganr() { Id = (int)Ganrs.SchoolLife, Name = "Школа" },
                new Ganr() { Id = (int)Ganrs.Boyovuk, Name = "Бойовик" },
                new Ganr() { Id = (int)Ganrs.Detektuv, Name = "Детектив" },
                new Ganr() { Id = (int)Ganrs.Drama, Name = "Драма" },
                new Ganr() { Id = (int)Ganrs.History, Name = "Історія" },
                new Ganr() { Id = (int)Ganrs.Comedy, Name = "Комедія" },
                new Ganr() { Id = (int)Ganrs.Romantic, Name = "Романтика" },
                new Ganr() { Id = (int)Ganrs.Hentai, Name = "Хентай" }
            });
        }

        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(new Roles[]
            {
                new Roles() { Id = TypesD.Admin.ToString(), Name = "Адмін" },
                new Roles() { Id = TypesD.Client.ToString(), Name = "Клієнт" },
            });
        }
    }
}
