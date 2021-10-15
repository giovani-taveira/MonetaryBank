using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.BancoDeDados
{
    public class Login
    {
        [Key]
        public string CPF { get; set; }
        [Required]
        [StringLength(50)]
        public string Senha { get; set; }
    }
}
