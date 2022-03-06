using Microsoft.EntityFrameworkCore;
using UnitTest.Models;
using UnitTest.Responsitory;
namespace UnitTest.Models {
    public class PersonDbContext : DbContext {
        public PersonDbContext() { }
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<Person> Persons { get; set; }
    }
}