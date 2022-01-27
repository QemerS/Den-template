using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Den.Models;

namespace Den.Data
{
    public class DenContext : DbContext
    {
        public DenContext (DbContextOptions<DenContext> options)
            : base(options)
        {
        }

        public DbSet<Den.Models.Setting> Setting { get; set; }

        public DbSet<Den.Models.Social> Social { get; set; }
    }
}
