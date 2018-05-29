using Microsoft.EntityFrameworkCore;
using Tutoriel.Models;

namespace Tutoriel.Data
{
    public class TutorielContext : DbContext
    {
        public TutorielContext(DbContextOptions<TutorielContext> options) : base(options) { }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
