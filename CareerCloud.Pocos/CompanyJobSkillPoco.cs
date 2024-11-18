using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Job")]
        public Guid Job { get; set; }
        [Column("Skill")]
        public string Skill { get; set; } = string.Empty;
        [Column("Skill_Level")]
        public string SkillLevel { get; set; } = string.Empty;
        [Column("Importance")]
        public int Importance { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];

        public virtual CompanyJobPoco CompanyJobSkillToJob { get; set; }
    }
}
