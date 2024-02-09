using Microsoft.EntityFrameworkCore;


namespace _09_02_24
{
    public class Connection : DbContext
    {
        public DbSet<Match> Matches { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = qmir-main; 
                                          Initial Catalog = MatchDataBase;
                                          Integrated Security = true;
                                          TrustServerCertificate = Yes;");
        }
    }
}
