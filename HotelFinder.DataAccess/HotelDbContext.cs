using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace HotelFinder.DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-16KPU01; Database=HotelDb;uid=hatice_user;pwd=Hatice.1234;Integrated Security=True;");
        }
        public DbSet<Hotel> Hotels { get; set; }

    }
}
