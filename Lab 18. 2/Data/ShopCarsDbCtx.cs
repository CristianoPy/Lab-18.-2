using Lab_18._2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18._2.Data
{
    internal class ShopCarsDbCtx : DbContext
    {
        public DbSet<Car> cars {  get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<Manual> Manuals { get; set; }


        public ShopCarsDbCtx()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\C#\Curso\C#7\Lab 18\Lab 18. 2\Lab 18. 2\Models\DbContext.mdf"";Integrated Security=True");
        }

    }
}
