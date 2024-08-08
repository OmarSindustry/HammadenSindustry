
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Authentication
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.Administrador.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Mantenimiento.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Consulta.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "javier",
                Email = "superadmin@gmail.com",
                FirstName = "Javier",
                LastName = "Armenta",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "P4ssw0rd.1");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Administrador.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Mantenimiento.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Consulta.ToString());
                }

            }
        }
    }
}
