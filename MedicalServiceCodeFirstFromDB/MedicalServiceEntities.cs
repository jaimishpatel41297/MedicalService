namespace MedicalServiceCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MedicalServiceEntities : DbContext
    {
        public MedicalServiceEntities()
            : base("name=MedicalServiceConnection")
        {
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Inquiry> Inquiries { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorName)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.PatientsFullName)
                .IsUnicode(false);

            modelBuilder.Entity<Treatment>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Treatment)
                .WillCascadeOnDelete(false);
        }
    }
}
