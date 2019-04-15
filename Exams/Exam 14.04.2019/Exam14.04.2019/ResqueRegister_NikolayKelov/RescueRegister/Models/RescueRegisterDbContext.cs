using Microsoft.EntityFrameworkCore;

namespace RescueRegister.Models
{
    public class RescueRegisterDbContext : DbContext
    {
       

        public DbSet<Mountaineer> Mountaineers { get; set; }

        private const string ConnectionString = @"Server = .\SQLEXPRESS;Database=ResqueRegisterDb;Integrated Security =True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
