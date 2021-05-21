using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cookaboo.Models;

namespace Cookaboo.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CookabooContext context)
        {
            context.Database.EnsureCreated();

            if (context.Recipes.Any())
            {
                return;
            }
            var recipes = new Recipes[]
            {
                new Recipes{name="PB&J", type="sandwhich", difficulty="easy", time="10 mins" }
            };
            foreach (Recipes r in recipes)
            {
                context.Recipes.Add(r);
            }
            context.SaveChanges();
        }
    }
}
