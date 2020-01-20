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
    
    public partial class TrackingTransaction
    {
        public int TrackingTransactionID { get; set; }
        public int MemberInGameID { get; set; }
        public Nullable<System.DateTime> TimeInitiated { get; set; }
        public Nullable<System.DateTime> TimePaused { get; set; }
        public Nullable<System.DateTime> TimeResumed { get; set; }
        public Nullable<System.DateTime> TimeCompleted { get; set; }
        public Nullable<double> DurationRemaining { get; set; }
        public Nullable<System.DateTime> DateInserted { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    
        public virtual MemberInGame MemberInGame { get; set; }
    }
}
