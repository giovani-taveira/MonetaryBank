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
        [Key]
        [StringLength(14)]
        public string CPF { get; set; }
        [ForeignKey("CPF")]
        public virtual Login cpf { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(1)]
        public string Sexo { get; set; }
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

        [StringLength(50)]
        public string Profissao { get; set; }
        [Column(TypeName = "Money")]
        public decimal Renda { get; set; }
    }
}
