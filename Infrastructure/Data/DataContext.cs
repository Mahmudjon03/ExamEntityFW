using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> option): base(option) => Database.EnsureCreated();
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Post> Posts { get; set; }
     }

