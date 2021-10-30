using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.BancoDeDados
{
    public class Historico
    {
        [Key()]
        public int Codigo_Operacao_ID { get; set; }
        [StringLength(14)]
        public string Cpf { get; set; }
        [StringLength(20)]
        public string Operacao { get; set; }
        [Column(TypeName = "Money")]
        public decimal Valor { get; set; }
        public string NomeRecebedor { get; set; }
        public DateTime Data_Operacao { get; set; }
    }
}
