using EntityFramework_CodeFirstMigrations_SQLServer_CRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_CodeFirstMigrations_SQLServer_CRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<MyEntity> MyEntities { get; set; }

    }
}
