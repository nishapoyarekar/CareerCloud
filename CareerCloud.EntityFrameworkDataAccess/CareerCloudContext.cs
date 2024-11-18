using CareerCloud.Pocos;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;


using System.IO;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionStr = SqlConnection();
            optionsBuilder.UseSqlServer(connectionStr);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantEducationPoco>(
                entity => {
                    entity.HasOne(primeentity => primeentity.ApplicantEducationToProfile)
                        .WithMany(foreignentity => foreignentity.ApplicantProfileToEducation)
                        .HasForeignKey(primeentity => primeentity.Applicant);
                });
            modelBuilder.Entity<ApplicantJobApplicationPoco>(
                entity => {
                    entity.HasOne(primeentity => primeentity.ApplicantJobToProfile)
                    .WithMany(foreignentity => foreignentity.ApplicantProfileToJob)
                    .HasForeignKey(primeentity => primeentity.Applicant);

                    entity.HasOne(primeentity => primeentity.ApplicantJobToCompanyJob)
                    .WithMany(foreignentity => foreignentity.CompanyJobToApplicantJob)
                    .HasForeignKey(primeentity => primeentity.Job);
                });
            modelBuilder.Entity<ApplicantProfilePoco>(
                entity => {
                    entity.HasOne(primeentity => primeentity.ApplicantProfileToSecurityLogin)
                    .WithOne(foreignentity => foreignentity.SecurityLoginToApplicantProfile)
                    .HasForeignKey<ApplicantProfilePoco>(primeentity => primeentity.Login);

                    entity.HasOne(primeentity => primeentity.ApplicantProfileToSystemCountry)
                    .WithMany(foreignentity => foreignentity.SystemCountryToApplicantProfile)
                    .HasForeignKey(primeentity => primeentity.Country);
                });
            modelBuilder.Entity<ApplicantResumePoco>(
                entity => {
                    entity.HasOne(primeentity => primeentity.ApplicantResumeToProfile)
                    .WithMany(foriegnentity => foriegnentity.ApplicantProfileToResume)
                    .HasForeignKey(primeentity => primeentity.Applicant);
                });
            modelBuilder.Entity<ApplicantSkillPoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.ApplicantSkillToProfile)
                    .WithMany(foreignentity => foreignentity.ApplicantProfileToSkill)
                    .HasForeignKey(primeentity => primeentity.Applicant);
                });
            modelBuilder.Entity<ApplicantWorkHistoryPoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.ApplicantWorkHistoryToProfile)
                    .WithMany(foreignentity => foreignentity.ApplicantProfileToWork)
                    .HasForeignKey(primeentity => primeentity.Applicant);

                    entity.HasOne(primeentity => primeentity.ApplicantWorkToSystemCountry)
                    .WithMany(foreignentity => foreignentity.SystemCountryToApplicantWork)
                    .HasForeignKey(primeentity => primeentity.CountryCode);
                });
            modelBuilder.Entity<CompanyDescriptionPoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.CompanyDescriptionToProfile)
                    .WithMany(foreignentity => foreignentity.CompanyProfileToDescription)
                    .HasForeignKey(primeentity => primeentity.Company);

                    entity.HasOne(primeentity => primeentity.CompanyDescriptionToSystemLanguage)
                    .WithMany(foreignentity => foreignentity.SystemLanguageToCompanyDescription)
                    .HasForeignKey(primeentity => primeentity.LanguageId);
                });
            modelBuilder.Entity<CompanyJobEducationPoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.CompanyJobEducationsToJob)
                    .WithOne(foreignentity => foreignentity.CompanyJobToEducation)
                    .HasForeignKey<CompanyJobEducationPoco>(primeentity => primeentity.Job);
                    entity.HasKey(k => new { k.Id, k.Job });
                });
            modelBuilder.Entity<CompanyJobSkillPoco>(
                entity => {
                    entity.HasOne(primeentity => primeentity.CompanyJobSkillToJob)
                    .WithMany(foreignentity => foreignentity.CompanyJobToJobSkill)
                    .HasForeignKey(primeentity => primeentity.Job);
                });
            modelBuilder.Entity<CompanyJobPoco>(
                entity => {
                    entity.HasOne(primeentity => primeentity.CompanyJobToProfile)
                    .WithMany(foreignentity => foreignentity.CompanyProfileToJob)
                    .HasForeignKey(primeentity => primeentity.Company);
                });
            modelBuilder.Entity<CompanyJobDescriptionPoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.CompanyJobDescriptionToJob)
                    .WithOne(foreignentity => foreignentity.CompanyJobToJobDescription)
                    .HasForeignKey<CompanyJobDescriptionPoco>(primeentity => primeentity.Job);
                });
            modelBuilder.Entity<CompanyLocationPoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.CompanyLocationToProfile)
                    .WithMany(foreignentity => foreignentity.CompanyProfileToLocation)
                    .HasForeignKey(primeentity => primeentity.Company);
                });
            modelBuilder.Entity<SecurityLoginsLogPoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.SecurityLoginLogToLogin)
                    .WithMany(foreignentity => foreignentity.SecurityLoginToLoginLog)
                    .HasForeignKey(primeentity => primeentity.Login);
                });
            modelBuilder.Entity<SecurityLoginsRolePoco>(
                entity =>
                {
                    entity.HasOne(primeentity => primeentity.SecurityLoginRoleToLogin)
                    .WithOne(foreignentity => foreignentity.SecurityLoginToLoginRole)
                    .HasForeignKey<SecurityLoginsRolePoco>(primeentity => primeentity.Login);

                    entity.HasOne(primeentity => primeentity.SecurityLoginRoleToRole)
                    .WithMany(foreignentity => foreignentity.SecurityRoleToLoginRole)
                    .HasForeignKey(primeentity => primeentity.Role);
                });

            base.OnModelCreating(modelBuilder);
        }
        private string SqlConnection()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            return root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }
    }
}
/*using CareerCloud.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            
            config.AddJsonFile(path, false);
            var root = config.Build();
            string _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            optionsBuilder.UseSqlServer(_connStr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantEducationPoco>(entity =>
            {
                entity.HasOne(ap => ap.ApplicantProfile)
                .WithMany(ae => ae.ApplicantEducations)
                .HasForeignKey(f => f.Applicant);
            });

            modelBuilder.Entity<ApplicantJobApplicationPoco>(entity =>
            {
                entity.HasOne(ap => ap.ApplicantProfile)
                .WithMany(aja => aja.ApplicantJobApplications)
                .HasForeignKey(f => f.Applicant);
            });
            modelBuilder.Entity<ApplicantJobApplicationPoco>(entity =>
            {
                entity.HasOne(cj => cj.CompanyJob)
                .WithMany(aja => aja.ApplicantJobApplications)
                .HasForeignKey(f => f.Job);
            });

            modelBuilder.Entity<ApplicantProfilePoco>(entity =>
            {
                entity.HasOne(sl => sl.SecurityLogin)
                .WithMany(ap => ap.ApplicantProfiles)
                .HasForeignKey(f => f.Login);
            });
            modelBuilder.Entity<ApplicantProfilePoco>(entity =>
            {
                entity.HasOne(scc => scc.SystemCountryCode)
                .WithMany(ap => ap.ApplicantProfiles)
                .HasForeignKey(f => f.Country);
            });

            modelBuilder.Entity<ApplicantResumePoco>(entity =>
            {
                entity.HasOne(ap => ap.ApplicantProfile)
                .WithMany(ar => ar.ApplicantResumes)
                .HasForeignKey(f => f.Applicant);
            });

            modelBuilder.Entity<ApplicantSkillPoco>(entity =>
            {
                entity.HasOne(ap => ap.ApplicantProfile)
                .WithMany(_as => _as.ApplicantSkills)
                .HasForeignKey(f => f.Applicant);
            });

            modelBuilder.Entity<ApplicantWorkHistoryPoco>(entity =>
            {
                entity.HasOne(ap => ap.ApplicantProfile)
                .WithMany(awh => awh.ApplicantWorkHistories)
                .HasForeignKey(f => f.Applicant);
            });
            modelBuilder.Entity<ApplicantWorkHistoryPoco>(entity =>
            {
                entity.HasOne(scc => scc.SystemCountryCode)
                .WithMany(awh => awh.ApplicantWorkHistories)
                .HasForeignKey(f => f.CountryCode);
            });

            modelBuilder.Entity<CompanyDescriptionPoco>(entity =>
            {
                entity.HasOne(cp => cp.CompanyProfile)
                .WithMany(cd => cd.CompanyDescriptions)
                .HasForeignKey(f => f.Company);
            });
            modelBuilder.Entity<CompanyDescriptionPoco>(entity =>
            {
                entity.HasOne(slc => slc.SystemLanguageCode)
                .WithMany(cd => cd.CompanyDescriptions)
                .HasForeignKey(f => f.LanguageId);
            });

            modelBuilder.Entity<CompanyJobDescriptionPoco>(entity =>
            {
                entity.HasOne(cj => cj.CompanyJob)
                .WithMany(cjd => cjd.CompanyJobDescriptions)
                .HasForeignKey(f => f.Job);
            });

            modelBuilder.Entity<CompanyJobEducationPoco>(entity =>
            {
                entity.HasOne(cj => cj.CompanyJob)
                .WithMany(cje => cje.CompanyJobEducations)
                .HasForeignKey(f => f.Job);
            });

            modelBuilder.Entity<CompanyJobPoco>(entity =>
            {
                entity.HasOne(cp => cp.CompanyProfile)
                .WithMany(cj => cj.CompanyJobs)
                .HasForeignKey(f => f.Company);
            });

            modelBuilder.Entity<CompanyJobSkillPoco>(entity =>
            {
                entity.HasOne(cj => cj.CompanyJob)
                .WithMany(cjs => cjs.CompanyJobSkills)
                .HasForeignKey(f => f.Job);
            });

            modelBuilder.Entity<CompanyLocationPoco>(entity =>
            {
                entity.HasOne(cp => cp.CompanyProfile)
                .WithMany(cl => cl.CompanyLocations)
                .HasForeignKey(f => f.Company);
            });

            modelBuilder.Entity<SecurityLoginsLogPoco>(entity =>
            {
                entity.HasOne(sl => sl.SecurityLogin)
                .WithMany(sll => sll.SecurityLoginsLogs)
                .HasForeignKey(f => f.Login);
            });

            modelBuilder.Entity<SecurityLoginsRolePoco>(entity =>
            {
                entity.HasOne(sl => sl.SecurityLogin)
                .WithMany(slr => slr.SecurityLoginsRoles)
                .HasForeignKey(f => f.Login);
            });
            modelBuilder.Entity<SecurityLoginsRolePoco>(entity =>
            {
                entity.HasOne(sr => sr.SecurityRole)
                .WithMany(slr => slr.SecurityLoginsRoles)
                .HasForeignKey(f => f.Role);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}*/
