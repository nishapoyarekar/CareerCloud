using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]

    public class CompanyJobPoco : IPoco
    {
        [Key][Column("Id")]
        public Guid Id { get; set; }
        [Column("Company")]
        public Guid Company { get; set; }
        [Column("Profile_Created")]
        public DateTime ProfileCreated { get; set; }
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }
        [Column("Is_Company_Hidden")]
        public bool IsCompanyHidden { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];

        public virtual ICollection<ApplicantJobApplicationPoco> CompanyJobToApplicantJob { get; set; }
        public virtual ICollection<CompanyJobSkillPoco> CompanyJobToJobSkill { get; set; }
        public virtual CompanyJobEducationPoco CompanyJobToEducation { get; set; }
        public virtual CompanyProfilePoco CompanyJobToProfile { get; set; }
        public virtual CompanyJobDescriptionPoco CompanyJobToJobDescription { get; set; }

    }
}
