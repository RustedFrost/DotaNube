//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dota2Nube.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            this.GameResult = new HashSet<GameResult>();
            this.Prediction = new HashSet<Prediction>();
        }
    
        public int GameId { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public int TournamentId { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Tournament Tournament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameResult> GameResult { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prediction> Prediction { get; set; }
    }
}
