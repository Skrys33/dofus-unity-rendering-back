using System.Threading;
using dofus_unity_rendering_back.Models.Metadata.Monster;
using Microsoft.EntityFrameworkCore;

namespace dofus_unity_rendering_back
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<Monsters> MonstersRecords { get; set; }
        public DbSet<MonsterGrade> MonsterGradeRecords { get; set; }
        public DbSet<AnimFunMonsterData> AnimFunMonsterRecords { get; set; }
        public DbSet<MonsterDrop> MonsterDropRecords { get; set; }
        public DbSet<MonsterDropCoefficient> MonsterDropCoefficientRecords { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MonsterDropCoefficient>()
                .HasKey(mg => new { mg.monsterGrade, mg.monsterId });


            modelBuilder.Entity<MonsterGrade>()
                .HasKey(mg => new { mg.grade, mg.monsterId });

            modelBuilder.Entity<MonsterDrop>()
                .HasKey(mg => new { mg.objectId, mg.dropId, mg.monsterId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
