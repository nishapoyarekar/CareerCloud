﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CareerCloud.Pocos
{
    [Table("Company_Locations")]
    public class CompanyLocationPoco : IPoco
    {
        [Key][Column("Id")]
        public Guid Id { get; set; }
        [Column("Company")]
        public Guid Company { get; set; }
        [Column("Country_Code")]
        public string CountryCode { get; set; } = string.Empty;
        [Column("State_Province_Code")]
        public string? Province { get; set; }
        [Column("Street_Address")]
        public string? Street { get; set; }
        [Column("City_Town")]
        public string? City { get; set; }
        [Column("Zip_Postal_Code")]
        public string? PostalCode { get; set; }
        [Column("Time_Stamp")]
        public byte[] TimeStamp { get; set; } = new byte[0];
        public virtual CompanyProfilePoco CompanyLocationToProfile { get; set; }

    }
}
