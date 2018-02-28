using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GymBokning01.Models
{

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //-navigation property
        //- Hittas också i “IdentityModels.cs” filen.
        //- En medlem kan boka flera pass, 
        //- alltså behöver klassen en kollektion av dessa pass:        public virtual System.Collections.Generic.ICollection<GymClass> AttendedClasses { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("GymBokningConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //- Navigation property -
        public DbSet<Models.GymClass> GymClass { get; set; }









        //public class RegisterContext : DbContext
        //{
        //    public RegisterContext() : base("GymBokningConnection")
        //    {
        //    }


        //}





        //- Se även Web.config:
        // <connectionStrings>
        //   <add name = "GymBokningConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-GymBokning01-20180228111659.mdf;Initial Catalog=aspnet-GymBokning01-20180228111659;Integrated Security=True" providerName="System.Data.SqlClient" />
        // </connectionStrings>






    }
}