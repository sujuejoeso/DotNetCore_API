using System;
using Microsoft.EntityFrameworkCore;
namespace MyApi.Models
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {
        }
        public DbSet<User> TodoItems { get; set; }
    }
}
