using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Biblioteca
{
    public class ContatoRep
    {

        public dbHelper db { get; set; }

        public ContatoRep(dbHelper DB)
        {
            db = DB;
        }

        public Contato Selecionar(Int64 recno)
        {
            var ret = db.Contatos.Where(c => c.recno == recno).FirstOrDefault();

            if (ret == null)
                return new Contato();
            else
                return ret;
        }

    }
}
