using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShaversWebApplication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ShaversWebApplication.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "admin@shavers.com",
                Email = "admin@shavers.com"
            };
            IdUserResult = userMgr.Create(appUser, "adminPassword");

            if (!userMgr.IsInRole(userMgr.FindByEmail("admin@shavers.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("admin@shavers.com").Id, "canEdit");
            }
        }
    }
}