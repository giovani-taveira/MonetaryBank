using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.BancoDeDados
{
    public class Login
    {
        [Key]
        public string cpf { get; set; }

        [StringLength(50)]
        public string Senha { get; set; }
        [Column(TypeName = "Money")]
        public decimal Saldo { get; set; }
    }
}
