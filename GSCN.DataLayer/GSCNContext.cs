using GSCN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GSCN.DataLayer
{
    public class GSCNContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<BankInfo> BankInformations { get; set; }

        public DbSet<EducationalDetails> EducationalDetails { get; set; }

        public DbSet<ContactDetails> ContactInformations { get; set; }

        public DbSet<FeesAndTiming> FeesAndTimings { get; set; }

        public DbSet<Experience> ExperienceDetails { get; set; }

        public DbSet<OtherInformation> OtherInformations { get; set; }



        public GSCNContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeesAndTiming>().HasKey(f => f.FandTId);
            modelBuilder.Entity<ContactDetails>().HasKey(t => t.ContactId);
            modelBuilder.Entity<Experience>().HasKey(t => t.ExperId);
            modelBuilder.Entity<OtherInformation>().HasKey(t => t.OtherId);
            modelBuilder.Entity<EducationalDetails>().HasKey(t => t.EducationalId);

        }

    }
}
