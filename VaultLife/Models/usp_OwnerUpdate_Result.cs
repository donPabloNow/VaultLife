//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vaultlife.Models
{
    using System;
    
    public partial class usp_OwnerUpdate_Result
    {
        public int OwnerID { get; set; }
        public string OwnerCode { get; set; }
        public string OwnerName { get; set; }
        public string OwnerType { get; set; }
        public string BankingDetailBank { get; set; }
        public string BankingDetailAccountNumber { get; set; }
        public string BankingDetailAccountType { get; set; }
        public string BankingDetailBranchCode { get; set; }
        public string BankingDetailBranchName { get; set; }
        public string BankingDetailDefaultReference { get; set; }
        public string EmailAddress { get; set; }
        public string ContactPerson { get; set; }
        public string TelephoneOffice { get; set; }
        public string TelephoneMobile { get; set; }
        public int AddressID { get; set; }
        public System.DateTime DateInserted { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string USR { get; set; }
    }
}