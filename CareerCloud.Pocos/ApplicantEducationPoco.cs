﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    public class ApplicantEducationPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Applicant")]
        public Guid Applicant { get; set; }
        [Column("Major")]
        public string Major { get; set; } = string.Empty;
        [Column("Completion_Percent")]
        public byte? CompletionPercent { get; set; }
        [Column("Certificate_Diploma")]
        public string? CertificateDiploma { get; set; }

        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }
        [Column("Completion_Date")]
        public DateTime? CompletionDate { get; set; }

        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];
        public virtual ApplicantProfilePoco ApplicantEducationToProfile { get; set; }

    }
}
