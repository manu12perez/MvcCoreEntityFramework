using Microsoft.EntityFrameworkCore;
using MvcCoreEntityFramework.Models;

namespace MvcCoreEntityFramework.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Hospital> Hospitales { get; set; }
    }
}
