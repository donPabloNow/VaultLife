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
    
    public partial class LanguageItem
    {
        public int LanguageItemID { get; set; }
        public int LanguageID { get; set; }
        public string LanguageItemKey { get; set; }
        public string LanguageItemValue { get; set; }
    
        public virtual Language Language { get; set; }
    }
}
