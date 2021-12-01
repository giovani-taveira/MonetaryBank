using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.BancoDeDados
{
    public class Endereco
    {
        [Key]
        [StringLength(9)]
        public string Cep { get; set; }
        [StringLength(100)]
        public string Logradouro { get; set; }
        [StringLength(10)]
        public string Numero { get; set; }
        [StringLength(100)]
        public string Complemento { get; set; }
        [StringLength(50)]
        public string Bairro { get; set; }
        [StringLength(50)]
        public string Cidade { get; set; }
        [StringLength(50)]
        public string Estado { get; set; }
    }
}
