using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Residential_capstone_project.Models;

[assembly: OwinStartupAttribute(typeof(Residential_capstone_project.Startup))]

namespace Residential_capstone_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

            private void createRolesandUsers()
        {
            //ApplicationDbContext context = new ApplicationDbContext();

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            //// In Startup iam creating first Admin Role and creating a default Admin User 
            //if (!roleManager.RoleExists("ADMIN"))
            //{

            //    // first we create Admin rool
            //    var role = new IdentityRole();
            //    role.Name = "ADMIN";
            //    roleManager.Create(role);

            //    //Here we create a Admin super user who will maintain the website				

            //    var user = new ApplicationUser();
            //    user.UserName = "Ryan_Wolff";
            //    user.Email = "ryan.wolff14@outlook.com";

            //    string userPWD = "Lostpanda024";

            //    var chkUser = UserManager.Create(user, userPWD);

            //    //Add default User to Role Admin
            //    if (chkUser.Succeeded)
            //    {
            //        var result1 = UserManager.AddToRole(user.Id, "Admin");

            //    }
            //}

            //// creating Creating Manager role 
            //if (!roleManager.RoleExists("Dorm Admin"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Dorm Admin";
            //    roleManager.Create(role);

            //}

            //// creating Creating Employee role 
            //if (!roleManager.RoleExists("Landlord"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Landlord";
            //    roleManager.Create(role);

            //}

            //if (!roleManager.RoleExists("Student<dorm>"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Student<dorm>";
            //    roleManager.Create(role);

            //}

            //if (!roleManager.RoleExists("Student<tenant>"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Student<tenant>";
            //    roleManager.Create(role);

            //}
        }
        }
    }
