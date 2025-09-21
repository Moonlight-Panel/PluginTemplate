using Microsoft.EntityFrameworkCore;
using Moonlight.ApiServer.Configuration;

namespace MoonlightPluginTemplate.ApiServer.Database;

public class MoonlightPluginTemplateDataContext : DbContext
{
    private readonly AppConfiguration Configuration;
    private readonly string Schema;
    
    public MoonlightPluginTemplateDataContext(AppConfiguration configuration)
    {
        Configuration = configuration;

        Schema = "MoonlightPluginTemplate".ToLower(); // Replace me
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(optionsBuilder.IsConfigured)
            return;

        var database = Configuration.Database;
        
        var connectionString = $"Host={database.Host};" +
                               $"Port={database.Port};" +
                               $"Database={database.Database};" +
                               $"Username={database.Username};" +
                               $"Password={database.Password}";

        optionsBuilder.UseNpgsql(connectionString, builder =>
        {
            builder.MigrationsHistoryTable("MigrationsHistory", Schema);
        });
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Model.SetDefaultSchema(Schema);
        
        base.OnModelCreating(modelBuilder);
    }
}