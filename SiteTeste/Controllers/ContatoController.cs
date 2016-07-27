using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Biblioteca;

namespace SiteTeste.Controllers
{

    public class ContatoController : ApiController
    {

        [HttpGet]
        public List<Contato> Teste()
        {
            var db = new dbHelper("default");
            var Contatos = db.Contatos.ToList();
            return Contatos;
        }

    }
}
