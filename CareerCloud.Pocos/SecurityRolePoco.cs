﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Security_Roles")]
    public class SecurityRolePoco : IPoco
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("Is_Inactive")]
        public bool IsInactive { get; set; }
        [Column("Role")]
        public string Role { get; set; } = string.Empty;

        public virtual ICollection<SecurityLoginsRolePoco> SecurityRoleToLoginRole { get; set; }
    }
}
