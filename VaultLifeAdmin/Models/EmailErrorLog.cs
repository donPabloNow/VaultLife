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
    
    public partial class EmailErrorLog
    {
        public long EmailErrorID { get; set; }
        public long EmailID { get; set; }
        public string RecipientEmailAddress { get; set; }
        public int MemberID { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public int SendAttempt { get; set; }
        public System.DateTime DateInserted { get; set; }
    
        public virtual Email Email { get; set; }
    }
}
