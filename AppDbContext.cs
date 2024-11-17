using System.Threading;
using dofus_unity_rendering_back.Models.Metadata.Effect;
using dofus_unity_rendering_back.Models.Metadata.Effect.Instance;
using dofus_unity_rendering_back.Models.Metadata.Monster;
using dofus_unity_rendering_back.Models.Metadata.Spell;
using dofus_unity_rendering_back.Models.Metadata.Translation;
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

        public DbSet<Spells> SpellsRecords { get; set; }
        public DbSet<SpellLevels> SpellLevelsRecords { get; set; }
        public DbSet<SpellVariants> SpellVariantsRecords { get; set; }
        public DbSet<BoundScriptUsageData> BoundScriptUsageDataRecords { get; set; }

        public DbSet<Effects> EffectsRecords { get; set; }
        public DbSet<EffectInstanceDice> EffectInstanceDiceRecords { get; set; }


        public DbSet<TranslatedLabel> TranslatedLabelRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TranslatedLabel>()
                .HasKey(mg => new { mg.id, mg.languageCode });

            modelBuilder.Entity<MonsterDropCoefficient>()
                .HasKey(mg => new { mg.monsterGrade, mg.monsterId });


            modelBuilder.Entity<MonsterGrade>()
                .HasKey(mg => new { mg.grade, mg.monsterId });

            modelBuilder.Entity<MonsterDrop>()
                .HasKey(mg => new { mg.objectId, mg.dropId, mg.monsterId });

            modelBuilder.Entity<Monsters>()
                .HasMany(m => m.spellsData)
                .WithMany()
                .UsingEntity(j => j.ToTable("Spells"));

            modelBuilder.Entity<EffectInstanceDice>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<EffectInstanceDice>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
