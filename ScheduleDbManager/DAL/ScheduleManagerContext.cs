using Microsoft.EntityFrameworkCore;
using ScheduleDbManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDbManager.DAL
{
    public class ScheduleManagerContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Projection> Projections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VLBQOSU;
                                        Database=ScheduleDb;
                                        Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
