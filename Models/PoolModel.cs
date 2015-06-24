using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota2Nube.Models
{
    public class PoolModel
    {
        public int PoolId { get; set; }
        public string PoolName { get; set; }
        public int UserId { get; set; }
        public int TournamentId { get; set; }

    }
}