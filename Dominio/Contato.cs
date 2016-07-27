using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{

    [Table("Contato")]
    public class Contato
    {
        [Key]
        public Int64 recno { get; set; }

        public String Nome { get; set; }

        public String Documento { get; set; }
    }
}
