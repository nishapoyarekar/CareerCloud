using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    public class SecurityLoginPoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Login")]
        public string Login { get; set; } = string.Empty;
        [Column("Password")]
        public string Password { get; set; } = string.Empty;
        [Column("Created_Date")]
        public DateTime Created { get; set; }
        [Column("Password_Update_Date")]
        public DateTime? PasswordUpdate { get; set; }
        [Column("Agreement_Accepted_Date")]
        public DateTime? AgreementAccepted { get; set; }
        [Column("Email_Address")]
        public string EmailAddress { get; set; } = string.Empty ;
        [Column("Phone_Number")]
        public string? PhoneNumber { get; set; }
        [Column("Full_Name")]
        public string? FullName { get; set; }
        [Column("Prefferred_Language")]
        public string? PrefferredLanguage { get; set; }

        [Column("Is_Locked")]
        public bool IsLocked { get; set; }
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }
        [Column("Force_Change_Password")]
        public bool ForceChangePassword { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];
        public virtual ICollection<SecurityLoginsLogPoco> SecurityLoginToLoginLog { get; set; }
        public virtual SecurityLoginsRolePoco SecurityLoginToLoginRole { get; set; }

        public virtual ApplicantProfilePoco SecurityLoginToApplicantProfile { get; set; }
    }
}
