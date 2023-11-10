using Microsoft.EntityFrameworkCore;

namespace API_6._0_SQRC.Repositories.Entities
{
    public class EFcontext: DbContext
    {
        public EFcontext( DbContextOptions<EFcontext> options) : base (options) { }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }
    }
}
