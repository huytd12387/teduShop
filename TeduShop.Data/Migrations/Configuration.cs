using System.Collections.Generic;
using TeduShop.Model.Models;

namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            CreatePostCategorySample(context);
        }

        private void CreatePostCategorySample(TeduShopDbContext context)
        {
            if (context.PostCategories.Count() == 0)
            {
                List<PostCategory> listPostCategories = new List<PostCategory>
                                                        {
                                                            new PostCategory {Name = "Test Post Category 1", Alias = "Test-Post-Category-1", Status = true},
                                                            new PostCategory {Name = "Test Post Category 2", Alias = "Test-Post-Category-2", Status = true},
                                                            new PostCategory {Name = "Test Post Category 3", Alias = "Test-Post-Category-3", Status = true}
                                                        };
                context.PostCategories.AddRange(listPostCategories);
                context.SaveChanges();
            }
        }
    }
}
