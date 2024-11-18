using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Applicant_Skills")]
    public class ApplicantSkillPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Applicant")]
        public Guid Applicant { get; set; }
        [Column("Skill")]
        public string Skill { get; set; } = string.Empty;
        [Column("Skill_Level")]
        public string SkillLevel { get; set; } = string.Empty;
        [Column("Start_Month")]
        public byte StartMonth { get; set; }
        [Column("Start_Year")]
        public int StartYear { get; set; }
        [Column("End_Month")]
        public byte EndMonth { get; set; }
        [Column("End_Year")]
        public int EndYear { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];

        public virtual ApplicantProfilePoco ApplicantSkillToProfile { get; set; }

    }
}
