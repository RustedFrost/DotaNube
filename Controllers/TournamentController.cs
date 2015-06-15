using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeyondThemes.BeyondAdmin.Controllers
{
    public class TournamentController : ApiController
    {
        #region Providers
        Entities.Provider.Tournament providerTournament = new Entities.Provider.Tournament(); 
        #endregion

        // GET: api/Tournament
        public List<Entities.Tournament> Get()
        {
            Entities.Dota2NubeEntities dataNube = new Entities.Dota2NubeEntities();
            return providerTournament.GetAllTournaments();
        }

        // GET: api/Tournament/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tournament
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tournament/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tournament/5
        public void Delete(int id)
        {
        }
    }
}
