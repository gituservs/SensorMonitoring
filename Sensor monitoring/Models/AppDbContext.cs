using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sensor_monitoring.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Readings> Readings { get; set; }
    }
}
