﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using FootballTeamManagment.Core.Models;

namespace FootballTeamManagment.Core.Persistence
{
    public static class ApplicationDatabaseSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            context.Database.Migrate();

            if(context.Roles.Count() == 0)
            {
                var roles = new List<Role>
                {
                    new Role { Name = ApplicationRole.Common.ToString() },
                    new Role { Name = ApplicationRole.Admin.ToString() }
                };

                context.Roles.AddRange(roles);
                context.SaveChanges();
            }
        }
    }
}
