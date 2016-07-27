using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SiteTeste.Controllers
{

    public class ContatoController : ApiController
    {

        [HttpGet]
        public string Teste()
        {
            return "ok";
        }

    }
}
