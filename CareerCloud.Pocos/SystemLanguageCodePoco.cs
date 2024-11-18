using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("System_Language_Codes")]
    public class SystemLanguageCodePoco
    {
        [Key]
        [Column("LanguageID")]
        public string LanguageID { get; set; } = string.Empty;
        [Column("Name")]
        public string Name { get; set; } = string.Empty;
        [Column("Native_Name")]
        public string NativeName { get; set; } = string.Empty;

        public virtual ICollection<CompanyDescriptionPoco> SystemLanguageToCompanyDescription { get; set; }
    }
}
