using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq;

namespace Repository
{
    public class eTeatarContext : DbContext
    {
        public eTeatarContext(DbContextOptions options) : base(options) { }

        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Avatar> Avatar { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Dvorana> Dvorana { get; set; }
        public DbSet<DvoranaTipSjedista> DvoranaTipSjedista { get; set; }
        public DbSet<Glumac> Glumac { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Komentar> Komentar { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
        public DbSet<Kupac> Kupac { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Obavijest> Obavijest { get; set; }
        public DbSet<Ocjena> Ocjena { get; set; }
        public DbSet<Predstava> Predstava { get; set; }
        public DbSet<PredstavaZanr> PredstavaZanr { get; set; }
        public DbSet<Teatar> Teatar { get; set; }
        public DbSet<Termin> Termin { get; set; }
        public DbSet<TipKorisnika> TipKorisnika { get; set; }
        public DbSet<TipSjedista> TipSjedista { get; set; }
        public DbSet<Uloga> Uloga { get; set; }
        public DbSet<Zanr> Zanr { get; set; }
        public DbSet<KorisnickaUloga> KorisnickaUloga { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Narudzba>().HasOne(e => e.Ocjena).WithOne(e => e.Narudzba).HasForeignKey<Ocjena>(e => e.NarudzbaId);

            //Iskljucenje restricted delete
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            #region Soft delete
            modelBuilder.Entity<Avatar>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Drzava>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Dvorana>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<DvoranaTipSjedista>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Glumac>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Grad>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Komentar>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<KorisnickiNalog>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Narudzba>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Obavijest>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Ocjena>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Predstava>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<PredstavaZanr>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Teatar>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Termin>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<TipKorisnika>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<TipSjedista>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Uloga>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Zanr>().HasQueryFilter(p => !p.IsDeleted);
            #endregion
        }

        //Soft Delete
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            var markedAsDeleted = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var item in markedAsDeleted)
            {
                if (item.Entity is IIsDeleted entity)
                {
                    item.State = EntityState.Unchanged;
                    entity.IsDeleted = true;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
