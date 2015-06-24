using Dota2Nube.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Dota2Nube.Controllers
{
    public class PoolController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string GetPools()
        {
            List<PoolModel> pools = new List<PoolModel>();

            Data.Dota2NubeConn1 db = new Data.Dota2NubeConn1();
            
            var dbpools = db.Pool.ToList();

            foreach (var item in dbpools)
            {
                pools.Add(new PoolModel
                {
                    PoolId = item.PoolId,
                    PoolName = item.PoolName
                });
            }

            return JsonConvert.SerializeObject(pools);
        }
    }
}
