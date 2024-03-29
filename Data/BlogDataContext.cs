using blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data;

public class BlogDataContext : DbContext{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
  //  public DbSet<PostTag> PostTags { get; set; }
    // public DbSet<Role> Roles { get; set; }
    // public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }
   // public DbSet<UserRole> UserRoles { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder options)
// => options.UseSqlServer(@"Data Source=IM-BRS-NT1071\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Initial Catalog=Blog; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnConfiguring(DbContextOptionsBuilder options){
     options.UseSqlServer(@"Data Source=IM-BRS-NT1071\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Initial Catalog=Blog; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
     
     options.LogTo(Console.WriteLine);
    }


}

