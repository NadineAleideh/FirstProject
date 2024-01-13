using FirstProject.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Developer> Developers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    List<Ticket> tickets = new List<Ticket>()
        //    {
        //        new Ticket(){ Id= 1, Title="Ticket1", Description="Ticket1_Description"},
        //        new Ticket(){ Id= 2, Title="Ticket2", Description="Ticket2_Description"},

        //        new Ticket(){ Id= 3, Title="Ticket3", Description="Ticket3_Description"},

        //        new Ticket() { Id = 4, Title = "Ticket4", Description = "Ticket4_Description" },
        //         new Ticket() { Id = 5, Title = "Ticket5", Description = "Ticket5_Description" },
        //          new Ticket() { Id = 6, Title = "Ticket6", Description = "Ticket7_Description" },
        //           new Ticket() { Id = 7, Title = "Ticket7", Description = "Ticket8_Description" }
        //    };

        //    modelBuilder.Entity<Ticket>().HasData(tickets);


        //    List<Developer> developers = new List<Developer>()
        //    {
        //        new Developer(){ Id= 1, Name ="Ahmad" },
        //        new Developer(){ Id= 2, Name = "Ali"},

        //        new Developer(){ Id= 3, Name = "Saly"},

        //        new Developer() { Id = 4, Name= "Sarah"},
        //    };

        //    modelBuilder.Entity<Developer>().HasData(developers);


        //}
    }
}
