namespace Mvc5UserCrud.Migrations
{
    using Controllers;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc5UserCrud.Models.UserDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mvc5UserCrud.Models.UserDbContext context)
        {
            int num = 0;
            foreach (var country in HomeController.GetCountries())
            {
                num++;
                context.Countries.AddOrUpdate(
                        new Models.Country { Name = country.Text, Id = num.ToString() }
                    );
            }
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 1", ID = "1", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 2", ID = "2", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 3", ID = "3", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 4", ID = "4", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 5", ID = "5", Checked = false });
        }
    }
}
