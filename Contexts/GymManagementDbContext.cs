using Microsoft.EntityFrameworkCore;

namespace GymManagementSystem.Contexts
{
    public class GymManagementDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ;Database = GymManagementSystem ; Trusted_Connection = true; TrustServerCertificate = true;");
        }
    }
}
