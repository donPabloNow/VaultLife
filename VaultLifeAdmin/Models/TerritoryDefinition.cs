//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VaultLifeAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TerritoryDefinition
    {
        public int TerritoryDefinitionID { get; set; }
        public string TerritoryDefinitionCode { get; set; }
        public int TerritoryID { get; set; }
        public string ZipOrPostalCode { get; set; }
        public string IPAddress { get; set; }
        public string PhysicalCoordinates { get; set; }
        public System.DateTime DateInserted { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string USR { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CityID { get; set; }
    
        public virtual Territory Territory { get; set; }
        public virtual Country Country { get; set; }
        public virtual CountryCity CountryCity { get; set; }
        public virtual CountryState CountryState { get; set; }
    }
}
