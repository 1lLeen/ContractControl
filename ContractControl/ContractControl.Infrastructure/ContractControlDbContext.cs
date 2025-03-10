using ContractControl.Infrastructure.Models.CompanyModels;
using ContractControl.Infrastructure.Models.ContractModels;
using ContractControl.Infrastructure.Models.MediatorModels;
using ContractControl.Infrastucture.ModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ContractControl.Infrastructure;

public class ContractControlDbContext : DbContext
{
    public DbSet<CompanyModel> Companies { get; set; }
    public DbSet<ContractModel> Contracts { get; set; }
    public DbSet<MediatorModel> Mediator { get; set; }

    public ContractControlDbContext() { }
    public ContractControlDbContext(DbContextOptions<ContractControlDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BaseConfiguration<CompanyModel>());
        modelBuilder.ApplyConfiguration(new BaseConfiguration<ContractModel>());
        modelBuilder.ApplyConfiguration(new BaseConfiguration<MediatorModel>());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=contractdb;Username=postgres;Password=jangir001");
    }
}
