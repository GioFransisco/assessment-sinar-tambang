using assessment_sinar_tambang.Models.DataTables;
using Microsoft.EntityFrameworkCore;

namespace assessment_sinar_tambang.Data
{
    public class MvcBuilder : DbContext
    {
        public MvcBuilder(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Matakuliah> matakuliah { get; set; }
        public DbSet<Dosen> dosen { get; set; }
    }
}
