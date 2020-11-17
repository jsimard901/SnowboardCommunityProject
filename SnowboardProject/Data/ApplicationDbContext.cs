using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SnowboardProject.Models;

namespace SnowboardProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

         public DbSet<ForumPost> ForumPosts {get; set;}
         public DbSet<Resort> ListOfResorts {get; set;}
        
        public DbSet<Resort> ListOfUserFavoriteResorts {get; set;}

         public DbSet<User> ListOfUserFriends {get;set;}

         public DbSet<User> ListOfUsers {get; set;}

    }
}
