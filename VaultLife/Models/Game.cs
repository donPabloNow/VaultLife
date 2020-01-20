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
    
    public partial class Game
    {
        public Game()
        {
            this.GameRules = new HashSet<GameRule>();
            this.GameSchedules = new HashSet<GameSchedule>();
            this.MemberInGames = new HashSet<MemberInGame>();
            this.ProductInGames = new HashSet<ProductInGame>();
            this.ProductInWatchLists = new HashSet<ProductInWatchList>();
        }
    
        public int GameID { get; set; }
        public string GameCode { get; set; }
        public int GameTypeID { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public System.DateTime DateInserted { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string USR { get; set; }
        public string GameCreationStatus { get; set; }
        public string GameState { get; set; }
        public int NumberOfWinners { get; set; }
        public Nullable<int> NextGameID { get; set; }
        public Nullable<int> MemberSubscriptionType { get; set; }
        public Nullable<bool> Global { get; set; }
    
        public virtual MemberSubscriptionType MemberSubscriptionType1 { get; set; }
        public virtual ICollection<GameRule> GameRules { get; set; }
        public virtual ICollection<GameSchedule> GameSchedules { get; set; }
        public virtual ICollection<MemberInGame> MemberInGames { get; set; }
        public virtual NextGame NextGame { get; set; }
        public virtual ICollection<ProductInGame> ProductInGames { get; set; }
        public virtual ICollection<ProductInWatchList> ProductInWatchLists { get; set; }
        public virtual GameType GameType { get; set; }
    }
}
