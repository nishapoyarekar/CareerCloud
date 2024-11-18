﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Company")]
        public Guid Company { get; set; }
        [Column("LanguageId")]
        public string? LanguageId { get; set; }
        [Column("Company_Name")]
        public string? CompanyName { get; set; }
        [Column("Company_Description")]
        public string? CompanyDescription { get; set; }
        [Column("Time_Stamp")]
        public byte[]? TimeStamp { get; set; }=new byte[0];
        public virtual CompanyProfilePoco CompanyDescriptionToProfile { get; set; }
        public virtual SystemLanguageCodePoco CompanyDescriptionToSystemLanguage { get; set; }

    }
}
