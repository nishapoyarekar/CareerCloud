﻿using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Current_Salary")]
        public decimal? CurrentSalary { get; set; }
        [Column("Current_Rate")]
        public decimal? CurrentRate { get; set; }
        [Column("Currency")]
        public string? Currency { get; set; }
        [Column("Country_Code")]
        public string? Country { get; set; }
        [Column("State_Province_Code")]
        public string? Province { get; set; }
        [Column("Street_Address")]
        public string? Street { get; set; }
        [Column("City_Town")]
        public string? City { get; set; }
        [Column("Zip_Postal_Code")]
        public string? PostalCode { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];
        [Column("Login")]
        public Guid Login { get; set; }

        public virtual SecurityLoginPoco SecurityLogin { get; set; }
        public virtual SystemCountryCodePoco SystemCountryCode { get; set; }
        public virtual ICollection<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public virtual ICollection<ApplicantResumePoco> ApplicantResumes { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }

        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantProfileToJob { get; set; }
        public virtual ICollection<ApplicantEducationPoco> ApplicantProfileToEducation { get; set; }
        public virtual SecurityLoginPoco ApplicantProfileToSecurityLogin { get; set; }
        public virtual SystemCountryCodePoco ApplicantProfileToSystemCountry { get; set; }
        public virtual ICollection<ApplicantResumePoco> ApplicantProfileToResume { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantProfileToSkill { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantProfileToWork { get; set; }
    }
}
