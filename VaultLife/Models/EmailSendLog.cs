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
    using System.Collections.Generic;
    
    public partial class EmailSendLog
    {
        public long SendLogID { get; set; }
        public long EmailID { get; set; }
        public string SendStatus { get; set; }
        public System.DateTime SendDateTime { get; set; }
    
        public virtual Email Email { get; set; }
    }
}