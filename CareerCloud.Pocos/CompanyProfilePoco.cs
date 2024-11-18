﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco :IPoco
    {
        [Key][Column("Id")]
        public Guid Id { get; set; }
        [Column("Registration_Date")]
        public DateTime RegistrationDate { get; set; }
        [Column("Company_Website")]
        public string? CompanyWebsite { get; set; }
        [Column("Contact_Phone")]
        public string ContactPhone { get; set; } = string.Empty;
        [Column("Contact_Name")]
        public string? ContactName { get; set; }
        [Column("Company_Logo")]
        public Byte[]? CompanyLogo { get; set; }
        [Column("Time_Stamp")]
        public Byte[]? TimeStamp { get; set; }

        public virtual ICollection<CompanyDescriptionPoco> CompanyProfileToDescription { get; set; }
        public virtual ICollection<CompanyJobPoco> CompanyProfileToJob { get; set; }
        public virtual ICollection<CompanyLocationPoco> CompanyProfileToLocation { get; set; }
    }
}
