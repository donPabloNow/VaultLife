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
    
    public partial class GameTemplate
    {
        public GameTemplate()
        {
            this.GameRules = new HashSet<GameRule>();
        }
    
        public int GameTemplateID { get; set; }
        public string GameTemplateCode { get; set; }
        public int GameTypeID { get; set; }
        public System.DateTime DateInserted { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string USR { get; set; }
        public string GameRuleCode { get; set; }
        public string GameRuleDetail { get; set; }
        public Nullable<int> OrderInGame { get; set; }
    
        public virtual GameType GameType { get; set; }
        public virtual ICollection<GameRule> GameRules { get; set; }
    }
}
