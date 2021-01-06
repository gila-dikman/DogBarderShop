using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBarderShopWebApp.Models
{
    public class DogBarbershopDBContext:DbContext
    {
        public DogBarbershopDBContext()
        {

        }
        public DogBarbershopDBContext(DbContextOptions<DogBarbershopDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-B4IVJP3\\MSSQLSERVER03; Database =DogBarbershop_DB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<User>();
            modelBuilder.Query<WatingToTurns>();
            modelBuilder.Query<TurnDetails>();
            modelBuilder.Query<Number>();
            modelBuilder.Query<Times>();
        }
    }
}
