using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nts_platform_server.Entities;

namespace nts_platform_server.Data
{
    public class Context : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactProject> ContactProject { get; set; }
        public DbSet<UserProject> UserProject { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Week> Week { get; set; }
        public DbSet<DocHour> DocHour { get; set; }

        public DbSet<ReportCheck> ReportChecks { get; set; }


        public Context(DbContextOptions<Context> options)
        : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add the shadow property to the model
            modelBuilder.Entity<DocHour>()
                .HasOne(p => p.Week);


            modelBuilder.Entity<Week>()
               .HasOne(p => p.MoHour);

            modelBuilder.Entity<Week>()
               .HasOne(p => p.ThHour);

            modelBuilder.Entity<Week>()
              .HasOne(p => p.TuHour);

            modelBuilder.Entity<Week>()
             .HasOne(p => p.WeHour);

            modelBuilder.Entity<Week>()
             .HasOne(p => p.FrHour);

            modelBuilder.Entity<Week>()
            .HasOne(p => p.SaHour);

            modelBuilder.Entity<Week>()
            .HasOne(p => p.SuHour);

            /*
            modelBuilder.Entity<Role>().HasData(
            new Role[]
            {
                new Role{Id =1,Title= "admin"},
                new Role{Id =2,Title= "engineer"},
                new Role{Id =3,Title= "guest"}
            });

            modelBuilder.Entity<Company>().HasData(
            new Company[]
            {
                new Company{Id =1,Name= "NTS"},
            });


            modelBuilder.Entity<Profile>().HasData(
           new Profile[]
           {
                new Profile{
                    Id = 1,
                    Sex = false,
                    Date = new DateTime(1994,08,18),
                    PrfSeries = "0414",
                    PrfNumber = "652893",
                    PrfDateTaked = new DateTime(2014,09,03),
                    PrfDateBack = new DateTime(2044,09,03),
                    PrfCode = "240-003",
                    PrfTaked = "Отделом УФМС РОССИИ ПО КРАСНОЯСРКОМУ КРАЮ В СОВЕТСКОМ Р-НЕ Г.КРАСНОЯСРКА",
                    PrfPlaceBorned = "ГОР. МИНСК БЕЛАРУСЬ",
                    PrfPlaceRegistration = "Россия, г. Красняосрк, ул. Урванецва, д. 6А, кв. 74",
                    PrfPlaceLived = "Россия, г. Красняосрк, ул. Урванецва, д. 6А, кв. 74",
                    IpNumber = "1111",
                    IpDateTaked = new DateTime(),
                    IpDateBack = new DateTime(),
                    IpCode = "111",
                    IpTaked = "МВД 24003",
                    IpPlaceBorned = "Гор. КРАСНОЯСРК / RUSSIA",
                    UlmNumber = "111",
                    UlmDateTaked = new DateTime(),
                    UlmDateBack = new DateTime(),
                    UlmTaked = "МВД 24003",
                    UlmPlaceBorned = "Гор. КРАСНОЯСРК / RUSSIA",
                    Snils = "1111",
                    Inn = "123412341234",
                    Phone = "79832068482",
                    PhotoName = "ava",
                },
           });

            modelBuilder.Entity<User>().HasData(
            new User[]
            {
                new User{
                    Id =1,
                    FirstName= "Сергей",
                    SecondName = "Смоглюк",
                    MiddleName = "Юрьевич",
                    Email = "xok",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    ProfileId = 1,
                    CompanyId = 1,
                    RoleId = 1,
                },
            });*/

        }



        
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
       
    }
}
