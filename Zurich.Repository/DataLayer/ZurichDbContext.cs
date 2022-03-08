using Microsoft.EntityFrameworkCore;
using Zurich.Domain.Models;

namespace Zurich.Repository.DataLayer
{
    public class ZurichDbContext : DbContext
    {
        public ZurichDbContext(DbContextOptions<ZurichDbContext> options) : base(options)
        {

        }

        #region "DbSet"
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Trainings> Trainings { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<ManageSubscription> ManageSubscription { get; set; }
        public DbSet<UserSubscription> UserSubscription { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> User { get; set; }
        #endregion
    }
}