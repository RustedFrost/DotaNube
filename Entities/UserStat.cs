//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserStat
    {
        public int UserStatId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public int TournamentId { get; set; }
    
        public virtual Tournament Tournament { get; set; }
        public virtual User User { get; set; }
    }
}
