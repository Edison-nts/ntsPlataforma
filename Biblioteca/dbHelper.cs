using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio;

namespace Biblioteca
{
    public class dbHelper: DbContext
    {
        public dbHelper(string conName)
            : base(conName)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
