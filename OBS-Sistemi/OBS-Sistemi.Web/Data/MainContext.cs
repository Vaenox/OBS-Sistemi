using Microsoft.EntityFrameworkCore;
using OBS_Sistemi.Web.Models;

namespace OBS_Sistemi.Web.Data
{
	public class MainContext:DbContext
	{
		public DbSet<Bolum> tb_Bolumler { get; set; }
		public DbSet<Danismanlik> tb_Danismanlik { get; set; }
		public DbSet<Degerlendirme> tb_Degerlendirme { get; set; }
		public DbSet<DersAcma> tb_DersAcma { get; set; }
		public DbSet<DersAlma> tb_DersAlma { get; set; }
		public DbSet<DersHavuzu> tb_DersHavuzu { get; set; }
		public DbSet<Derslik> tb_Derslik { get; set; }
		public DbSet<DersProgrami> tb_DersProgrami { get; set; }
		public DbSet<Kullanici> tb_Kullanicilar { get; set; }
		public DbSet<Mufredat> tb_Mufredat { get; set; }
		public DbSet<Ogrenci> tb_Ogrenciler { get; set; }
		public DbSet<OgretimElemani> tb_OgretimElemani { get; set; }
		public DbSet<Sinav> tb_Sinav { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
			optionsBuilder.UseSqlServer("Server=DESKTOP-4UEBQES\\SQLEXPRESS03;Database=OBSWebDB;Trusted_Connection=True;TrustServerCertificate=True");
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Kullanici>().HasKey(k => k.KullaniciID);
            modelBuilder.Entity<Bolum>().HasKey(b => b.BolumID);
			modelBuilder.Entity<Danismanlik>().HasKey(d => d.DanismanlikID);
            modelBuilder.Entity<DersAcma>().HasKey(dac => dac.DersAcmaID);
            modelBuilder.Entity<DersAlma>().HasKey(dal=> dal.DersAlmaID);
            modelBuilder.Entity<DersHavuzu>().HasKey(dh => dh.DersID);
            modelBuilder.Entity<Derslik>().HasKey(d => d.DerslikID);
            modelBuilder.Entity<DersProgrami>().HasKey(dp => dp.DersPrgID);
            modelBuilder.Entity<Kullanici>().HasKey(k => k.KullaniciID);
            modelBuilder.Entity<Mufredat>().HasKey(m => m.MufredatID);
            modelBuilder.Entity<Ogrenci>().HasKey(o => o.OgrenciID);
            modelBuilder.Entity<OgretimElemani>().HasKey(oe => oe.OgrElmID);
            modelBuilder.Entity<Sinav>().HasKey(s => s.SinavID);






            

            base.OnModelCreating(modelBuilder);
            
        }
	}
}
