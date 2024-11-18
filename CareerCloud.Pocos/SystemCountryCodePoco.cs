using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareerCloud.Pocos
{
    [Table("System_Country_Codes")]
    public class SystemCountryCodePoco
    {
        [Key][Column("Code")]
        public string Code { get; set; } = string.Empty;
        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<ApplicantProfilePoco> SystemCountryToApplicantProfile { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> SystemCountryToApplicantWork { get; set; }
    }
}
