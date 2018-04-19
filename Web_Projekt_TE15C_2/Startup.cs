using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;
using Web_Projekt_TE15C_2.Models;

[assembly: OwinStartupAttribute(typeof(Web_Projekt_TE15C_2.Startup))]
namespace Web_Projekt_TE15C_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
             CreateRoles();
             CreateAdmin();
        }

        private void CreateRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));


            if (!roleManager.RoleExists("Customer"))
               {
              var role = new IdentityRole();
              role.Name = "Customer";
              roleManager.Create(role);
               }
            if (!roleManager.RoleExists("Admin"))
              {
              var role = new IdentityRole();
              role.Name = "Admin";
              roleManager.Create(role);
              }
            }

    private void CreateAdmin()
    {
        ApplicationDbContext context = new ApplicationDbContext();
        var userManager =
            new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
        if (userManager.FindByEmail("admin@admin.com") == null)
        {
            var user = new ApplicationUser();
            user.Email = "admin@admin.com";
            user.UserName = "admin@admin.com";
            string password = "Password1!";
            userManager.Create(user, password);
            userManager.SetLockoutEnabled(user.Id, false);
            userManager.AddToRoleAsync(user.Id, "Admin");

        }
    }
  }
}
