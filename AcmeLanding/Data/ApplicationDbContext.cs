using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcmeLanding.Data
{
    public class Acme_CorporationContext : IdentityDbContext
    {
        public Acme_CorporationContext(DbContextOptions<Acme_CorporationContext> options)
            : base(options)
        {
        }
        public DbSet<ClassLibrary.Submission_Model> Submission_Model { get; set; }
    }
}
