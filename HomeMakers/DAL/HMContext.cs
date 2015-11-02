using HomeMakers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace HomeMakers.DAL
{
    public class HMContext : DbContext
    {
    }

    public DbSet<Category> Category { get; set; }
    public DbSet<Comment> Comment { get; set; }
    public DbSet<Community> Community { get; set; }
    public DbSet<Follow> Follow { get; set; }
    public DbSet<Forum> Forum { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Person_Community> Person_Community { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<Post_Category> Post_Category { get; set; }
    public DbSet<Role> Role { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

}