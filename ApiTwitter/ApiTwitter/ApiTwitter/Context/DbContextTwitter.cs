using System;
using ApiTwitter.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiTwitter.Context
{
    public class DbContextTwitter : DbContext
    {
        public DbContextTwitter(DbContextOptions<DbContextTwitter> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Follower> Followers { get; set; }
    }
}
