using CakeAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeAPI.Data
{
    public static class CakeSeed
    {
        public static void Seed(CakeContext context)
        {
            context.Database.Migrate();

            if (!context.Cakes.Any()){
                context.Cakes.AddRange(GetPreConfigureCakes());

                context.SaveChanges();
            }
        }

        private static IEnumerable<Cake> GetPreConfigureCakes()
        {
            return new List<Cake>()
            {
                new Cake() {Id=5, Description="First Cake", Title="Doll Cake", PictureUrl="http://cakes/api/pic/1"},
                new Cake() {Id=6, Description="Second Cake", Title="SuperHero Cake", PictureUrl="http://cakes/api/pic/2"},
            };
        }

       
    }

}

