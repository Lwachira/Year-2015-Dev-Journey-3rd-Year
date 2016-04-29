using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace AviaCo.Models
{
    public partial class AVIACOContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=DESKTOP-S2DDF7Q;Initial Catalog=AVIACO;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AIRCRAFT>(entity =>
            {
                entity.HasKey(e => e.AC_NUMBER);

                entity.Property(e => e.AC_NUMBER)
                    .HasMaxLength(5)
                    .HasColumnType("char");

                entity.Property(e => e.AC_TTAF).HasColumnType("numeric");

                entity.Property(e => e.AC_TTEL).HasColumnType("numeric");

                entity.Property(e => e.AC_TTER).HasColumnType("numeric");

                entity.Property(e => e.MOD_CODE)
                    .HasMaxLength(10)
                    .HasColumnType("char");

                entity.HasOne(d => d.MOD_CODENavigation).WithMany(p => p.AIRCRAFT).HasForeignKey(d => d.MOD_CODE);
            });

            modelBuilder.Entity<CHARTER>(entity =>
            {
                entity.HasKey(e => e.CHAR_TRIP);

                entity.Property(e => e.CHAR_TRIP).ValueGeneratedNever();

                entity.Property(e => e.AC_NUMBER)
                    .HasMaxLength(5)
                    .HasColumnType("char");

                entity.Property(e => e.CHAR_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHAR_DESTINATION)
                    .HasMaxLength(3)
                    .HasColumnType("char");

                entity.Property(e => e.CHAR_FUEL_GALLONS).HasColumnType("numeric");

                entity.Property(e => e.CHAR_HOURS_FLOWN).HasColumnType("numeric");

                entity.Property(e => e.CHAR_HOURS_WAIT).HasColumnType("numeric");

                entity.HasOne(d => d.AC_NUMBERNavigation).WithMany(p => p.CHARTER).HasForeignKey(d => d.AC_NUMBER);

                entity.HasOne(d => d.CUS_CODENavigation).WithMany(p => p.CHARTER).HasForeignKey(d => d.CUS_CODE).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CREW>(entity =>
            {
                entity.Property(e => e.crewID).ValueGeneratedOnAdd();

                entity.Property(e => e.CREW_JOB)
                    .HasMaxLength(20)
                    .HasColumnType("varchar");

                entity.HasOne(d => d.CHAR_TRIPNavigation).WithMany(p => p.CREW).HasForeignKey(d => d.CHAR_TRIP).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.EMP_NUMNavigation).WithMany(p => p.CREW).HasForeignKey(d => d.EMP_NUM).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CUSTOMER>(entity =>
            {
                entity.HasKey(e => e.CUS_CODE);

                entity.Property(e => e.CUS_CODE).ValueGeneratedNever();

                entity.Property(e => e.CUS_AREACODE)
                    .HasMaxLength(3)
                    .HasColumnType("char");

                entity.Property(e => e.CUS_BALANCE).HasColumnType("numeric");

                entity.Property(e => e.CUS_FNAME)
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.Property(e => e.CUS_INITIAL)
                    .HasMaxLength(1)
                    .HasColumnType("char");

                entity.Property(e => e.CUS_LNAME)
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.Property(e => e.CUS_PHONE)
                    .HasMaxLength(8)
                    .HasColumnType("char");
            });

            modelBuilder.Entity<CUSTOMER_MAINT>(entity =>
            {
                entity.HasKey(e => e.CUS_CODE);

                entity.Property(e => e.CUS_CODE).ValueGeneratedNever();

                entity.Property(e => e.CUS_AREACODE)
                    .HasMaxLength(3)
                    .HasColumnType("char");

                entity.Property(e => e.CUS_FNAME)
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.Property(e => e.CUS_INITIAL)
                    .HasMaxLength(1)
                    .HasColumnType("char");

                entity.Property(e => e.CUS_LNAME)
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.Property(e => e.CUS_PHONE)
                    .HasMaxLength(8)
                    .HasColumnType("char");
            });

            modelBuilder.Entity<EARNEDRATING>(entity =>
            {
                entity.HasKey(e => new { e.EMP_NUM, e.RTG_CODE });

                entity.Property(e => e.RTG_CODE)
                    .HasMaxLength(5)
                    .HasColumnType("char");

                entity.Property(e => e.EARNRTG_DATE).HasColumnType("datetime");

                entity.HasOne(d => d.EMP_NUMNavigation).WithMany(p => p.EARNEDRATING).HasForeignKey(d => d.EMP_NUM).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.RTG_CODENavigation).WithMany(p => p.EARNEDRATING).HasForeignKey(d => d.RTG_CODE).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EMPLOYEE>(entity =>
            {
                entity.HasKey(e => e.EMP_NUM);

                entity.Property(e => e.EMP_NUM).ValueGeneratedNever();

                entity.Property(e => e.EMP_DOB).HasColumnType("datetime");

                entity.Property(e => e.EMP_FNAME)
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.Property(e => e.EMP_HIRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_INITIAL)
                    .HasMaxLength(1)
                    .HasColumnType("char");

                entity.Property(e => e.EMP_LNAME)
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.Property(e => e.EMP_TITLE)
                    .HasMaxLength(4)
                    .HasColumnType("char");
            });

            modelBuilder.Entity<MODEL>(entity =>
            {
                entity.HasKey(e => e.MOD_CODE);

                entity.Property(e => e.MOD_CODE)
                    .HasMaxLength(10)
                    .HasColumnType("char");

                entity.Property(e => e.MOD_CHG_MILE).HasColumnType("numeric");

                entity.Property(e => e.MOD_MANUFACTURER)
                    .HasMaxLength(15)
                    .HasColumnType("varchar");

                entity.Property(e => e.MOD_NAME)
                    .HasMaxLength(20)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<PILOT>(entity =>
            {
                entity.HasKey(e => e.EMP_NUM);

                entity.Property(e => e.EMP_NUM).ValueGeneratedNever();

                entity.Property(e => e.PIL_LICENSE)
                    .HasMaxLength(25)
                    .HasColumnType("varchar");

                entity.Property(e => e.PIL_MED_DATE).HasColumnType("datetime");

                entity.Property(e => e.PIL_MED_TYPE)
                    .HasMaxLength(1)
                    .HasColumnType("char");

                entity.Property(e => e.PIL_PT135_DATE).HasColumnType("datetime");

                entity.Property(e => e.PIL_RATINGS)
                    .HasMaxLength(30)
                    .HasColumnType("varchar");

                entity.HasOne(d => d.EMP_NUMNavigation).WithOne(p => p.PILOT).HasForeignKey<PILOT>(d => d.EMP_NUM).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<RATING>(entity =>
            {
                entity.HasKey(e => e.RTG_CODE);

                entity.Property(e => e.RTG_CODE)
                    .HasMaxLength(5)
                    .HasColumnType("char");

                entity.Property(e => e.RTG_NAME)
                    .HasMaxLength(50)
                    .HasColumnType("varchar");
            });

            modelBuilder.Entity<sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.diagram_id);

                entity.Property(e => e.definition).HasColumnType("varbinary");
            });
        }

        public virtual DbSet<AIRCRAFT> AIRCRAFT { get; set; }
        public virtual DbSet<CHARTER> CHARTER { get; set; }
        public virtual DbSet<CREW> CREW { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<CUSTOMER_MAINT> CUSTOMER_MAINT { get; set; }
        public virtual DbSet<EARNEDRATING> EARNEDRATING { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<MODEL> MODEL { get; set; }
        public virtual DbSet<PILOT> PILOT { get; set; }
        public virtual DbSet<RATING> RATING { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}