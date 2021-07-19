using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Ashram> Ashrams { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Seva> Sevas { get; set; }
        public DbSet<SevaAllocation> SevaAllocations { get; set; }
        public DbSet<SevaType> SevaTypes { get; set; }

    }
}