﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
    public class CompanyJobDescriptionPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Job")]
        public Guid Job { get; set; }
        [Column("Job_Name")]
        public string? JobName { get; set; }
        [Column("Job_Descriptions")]
        public string? JobDescriptions { get; set; }
        [Column("Time_Stamp")]
        public byte[]? TimeStamp { get; set; } = new byte[0];
        public virtual CompanyJobPoco CompanyJobDescriptionToJob { get; set; }
    }
}
