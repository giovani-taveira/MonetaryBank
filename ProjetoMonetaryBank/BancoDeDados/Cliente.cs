using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.BancoDeDados
{
    public class Cliente
    {
        //public int ID { get; set; }
        [Key]
        [StringLength(14)]
        public string CPF { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        public char Sexo { get; set; }
        [StringLength(12)]
        public string RG { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(10)]
        public string Nacimento { get; set; }
        [StringLength(14)]
        public string Telefone { get; set; }
        [StringLength(50)]
        public string NomeMae { get; set; }
        public bool NaoConstaMae { get; set; }
        [StringLength(50)]
        public string NomePai { get; set; }
        public bool NaoConstaPai { get; set; }
        [StringLength(9)]
        public string CEP { get; set; }
        [ForeignKey("CEP")]
        public virtual Endereco Cep { get; set; }
        [StringLength(50)]
        public string Profissao { get; set; }
        [StringLength(15)]
        public string Renda { get; set; }
    }
}
