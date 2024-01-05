using DataAcess.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class MangaDbContext : IdentityDbContext
    {
        public MangaDbContext()
        {

        }
        public MangaDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("workstation id=Db_manga.mssql.somee.com;packet size=4096;user id=Vlad2222_SQLLogin_1;pwd=pf6732339x;data source=Db_manga.mssql.somee.com;persist security info=False;initial catalog=Db_manga");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MangaGanr>()
                .HasKey(sc => new { sc.MangaId, sc.GanrId });

            modelBuilder.Entity<MangaGanr>()
                .HasOne(sc => sc.Manga)
                .WithMany(s => s.Ganrs)
                .HasForeignKey(sc => sc.MangaId);

            modelBuilder.Entity<MangaGanr>()
                .HasOne(sc => sc.Ganr)
                .WithMany(c => c.Mangas)
                .HasForeignKey(sc => sc.GanrId);

            modelBuilder.Entity<VideosGanr>()
                .HasKey(sc => new { sc.VideosId, sc.GanrId });

            modelBuilder.Entity<VideosGanr>()
                .HasOne(sc => sc.Videoses)
                .WithMany(s => s.Ganrs)
                .HasForeignKey(sc => sc.VideosId);

            modelBuilder.Entity<VideosGanr>()
                .HasOne(sc => sc.Ganr)
                .WithMany(c => c.Videoses)
                .HasForeignKey(sc => sc.GanrId);

            modelBuilder.SeedGanrs();
            modelBuilder.SeedRoles();
        }

        public virtual DbSet<Manga> Mangas { get; set; }
        public virtual DbSet<Videos> Videoses { get; set; }
        public virtual DbSet<Ganr> Ganrs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Roles> Roleses { get; set; }
    }
}
