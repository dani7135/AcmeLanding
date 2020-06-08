using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Acme_CorporationContext : DbContext
    {
        public Acme_CorporationContext(DbContextOptions<Acme_CorporationContext> options) : base(options) { }
        public DbSet<Acme_CorporationContext> Submission_Model { get; set; }
    }
}
