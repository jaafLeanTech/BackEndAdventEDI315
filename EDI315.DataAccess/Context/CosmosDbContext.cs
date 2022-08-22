using EDI.Entities.Entities;
using EDI315.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace EDI315.DataAccess.Context
{
    public class CosmosDbContext : DbContext
    {
        public CosmosDbContext(DbContextOptions<CosmosDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                "https://mytutorialapp.documents.azure.com:443/",
                "hm1l0k5AMlg6gn09SDQN9hmLtYkziLIQZwiR59Um559dGAnvjsRl1WhWIywJwU6iujkVMRsZUDIyh3PS1ZcWuQ==",
                "Tasks"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemContainer>()
                .ToContainer("X12_315")
                .HasOne(item => item.ContainerId);
        }
    }
}
