using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Applicant")]
        public Guid? Applicant { get; set; }
        [Column("Location")]
        public string? Location { get; set; } = string.Empty;
        [Column("Company_Name")]
        public string CompanyName { get; set; } = string.Empty;
        [Column("Country_Code")]
        public string CountryCode { get; set; } = string.Empty;
        [Column("Job_Title")]
        public string JobTitle { get; set; } = string.Empty;
        [Column("Job_Description")]
        public string JobDescription { get; set; } = string.Empty;
        [Column("Start_Year")]
        public int StartYear { get; set; }
        [Column("Start_Month")]
        public short StartMonth { get; set; }
        [Column("End_Month")]
        public short EndMonth { get; set; }
        [Column("End_Year")]
        public int EndYear { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];

        public virtual ApplicantProfilePoco ApplicantWorkHistoryToProfile { get; set; }
        public virtual SystemCountryCodePoco ApplicantWorkToSystemCountry { get; set; }
    }
}
