using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DBDemo
{
    public class Program
    {
        public static void Main()
        {
            // AddManufacturers();
            // DeleteManufacturById(6);

            // ChangeManufacturerName("BridgeStone","Toyoyoyoy");

            AddTyre("Kauchuk", 50, "Summer", 12);


            var manufacturers = GetManufacturers();
            foreach (var man in manufacturers)
            {
                Console.WriteLine($"I am {man.Name} with {man.Email}. I have Id= {man.Id}");
            }
        }

        private static void ChangeManufacturerName(string oldName, string newName)
        {
            using (TyreDBContext db = TyreContextFactory.CreateDbContext())
            {
                var manufacturerFd = db.Manufacturers.FirstOrDefault(m => m.Name == oldName);
                manufacturerFd.Name = newName;
                db.SaveChanges();
            }
        }

        private static List<Manufacturer> GetManufacturers()
        {
            using (TyreDBContext db = TyreContextFactory.CreateDbContext())
            {
                return db.Manufacturers.ToList();
            }
        }

        private static void AddManufacturers()
        {
            string manNames = "Michelin,GoodYear,Continental,GoodRide,BridgeStone";

            List<Manufacturer> mans = manNames.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => new Manufacturer(n, $"{n.ToLower()}@gmail.com")).ToList();

            using (TyreDBContext db = TyreContextFactory.CreateDbContext())
            {
                db.AddRange(mans);
                db.SaveChanges();
            }
        }

        private static void DeleteManufacturById(int id)
        {
            using (TyreDBContext db = TyreContextFactory.CreateDbContext())
            {
                db.Remove(db.Manufacturers.FirstOrDefault(m => m.Id == id));
                db.SaveChanges();
            }
        }

        public static void AddTyre(string material,double size,string season, int manId)
        {
            Tyre tyre = new Tyre() { Material=material,Size=size,Season=season};
            
            using (TyreDBContext db = TyreContextFactory.CreateDbContext())
            {
                var manufacturerFd = db.Manufacturers.FirstOrDefault(m => m.Id == manId);
                tyre.Manufacturer = manufacturerFd;

                db.Add(tyre);
                db.SaveChanges();
            }
        }


    }
}
