using ArtStore.Application.Interfaces.Contexts;
using ArtStore.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtStore.Persistence.Context
{
   public class DataBaseContext:DbContext,IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles  { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }


    }
}
