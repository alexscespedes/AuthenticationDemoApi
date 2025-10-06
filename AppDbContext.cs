using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace AuthDemoApi;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
}
