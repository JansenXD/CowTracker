using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CowTracker;

namespace CowTracker.Data
{
    public class CowTrackerContext : DbContext
    {
        public CowTrackerContext (DbContextOptions<CowTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<CowTracker.Calf> Calf { get; set; } = default!;
        public DbSet<CowTracker.PenDB> PenDB { get; set; } = default!;
    }
}
