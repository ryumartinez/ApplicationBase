using Accessors.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accessors;

public class AppDbContext : DbContext
{
  public DbSet<User> Users { get; set; }
}