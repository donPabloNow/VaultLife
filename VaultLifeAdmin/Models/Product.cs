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
    
    public partial class Product
    {
        public Product()
        {
            this.DisplayItems = new HashSet<DisplayItem>();
            this.ProductInCategories = new HashSet<ProductInCategory>();
            this.ProductInWatchLists = new HashSet<ProductInWatchList>();
            this.ProductInGames = new HashSet<ProductInGame>();
            this.Imagedetails = new HashSet<Imagedetail>();
        }
    
        public int ProductID { get; set; }
        public string ProductSKUCode { get; set; }
        public int OwnerID { get; set; }
        public int ContractID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public System.DateTime DateInserted { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string USR { get; set; }
        public bool IsExclusive { get; set; }
        public Nullable<int> SOH { get; set; }
        public Nullable<int> AvailableSOH { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public string terms { get; set; }
        public string link { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual ICollection<DisplayItem> DisplayItems { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual ICollection<ProductInCategory> ProductInCategories { get; set; }
        public virtual ICollection<ProductInWatchList> ProductInWatchLists { get; set; }
        public virtual ICollection<ProductInGame> ProductInGames { get; set; }
        public virtual ICollection<Imagedetail> Imagedetails { get; set; }
    }
}
