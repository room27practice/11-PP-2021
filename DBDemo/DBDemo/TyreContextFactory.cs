using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

//Console Package Manager
//Add-Migration nameOfMigration
//Update-database

namespace DBDemo
{
    public class TyreContextFactory : IDesignTimeDbContextFactory<TyreDBContext>
    {
        static readonly string constr = "Server=DESKTOP-H86OA8E\\SQLEXPRESS;Database=TyreDB;Trusted_Connection=True;";
        public TyreDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TyreDBContext>();
            optionsBuilder.UseSqlServer(constr);

            return new TyreDBContext(optionsBuilder.Options);
        }
        public static TyreDBContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TyreDBContext>();
            optionsBuilder.UseSqlServer(constr);

            return new TyreDBContext(optionsBuilder.Options);
        }



    }
}
