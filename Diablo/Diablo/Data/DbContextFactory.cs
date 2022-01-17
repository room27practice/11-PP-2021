//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Diablo
//{
//    public class DbContextFactory : IDesignTimeDbContextFactory<DiabloDbContext>
//    {
//        static readonly string constr = "Server=DESKTOP-H86OA8E\\SQLEXPRESS;Database=TyreDB;Trusted_Connection=True;";
//        public DiabloDbContext CreateDbContext(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<DiabloDbContext>();
//            optionsBuilder.UseSqlServer(constr);

//            return new DiabloDbContext(optionsBuilder.Options);
//        }
//        public static DiabloDbContext CreateDbContext()
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<DiabloDbContext>();
//            optionsBuilder.UseSqlServer(constr);

//            return new DiabloDbContext(optionsBuilder.Options);
//        }
//    }
//}