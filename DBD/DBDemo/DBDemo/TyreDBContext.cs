using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDemo
{
    public class TyreDBContext : DbContext
    {


        public TyreDBContext()
        { }

        public TyreDBContext(DbContextOptions<TyreDBContext> options)
                  : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder
        //            .UseSqlServer(constr);
        //    }
        //}


        public DbSet<Tyre> Tyres { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }


    }
}
