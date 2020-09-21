using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TourApp.Entity;

namespace TourApp.Seed
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().HasData(
                new Tour
                {
                
                }
            );
        }
    }
}
