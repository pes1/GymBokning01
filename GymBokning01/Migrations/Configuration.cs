namespace GymBokning01.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GymBokning01.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GymBokning01.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GymBokning01.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.GymClass.AddOrUpdate(
                c => c.Id,
                new GymClass
                {
                    Id          = 1001,
                    Name        = "Stretch",
                    Description = "Sträck & drag",
                    Duration    = new TimeSpan(hours: 0, minutes:45, seconds:0),
                    StartTime   = new DateTime(year: 2018, month: 3, day:7, hour:7, minute:0, second:0)
                    
                });
                    
                



        }
    }
}
