using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoMonetaryBank.Inicializacao
{
    class Validacoes
    {
        public class Unit
        {
            
            [Required(ErrorMessage = "Nome é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome  deve ter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai deve ter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            
            [StringLength(50, ErrorMessage = "Nome da Mãe deve ter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }

            public bool TemMae { get; set; }
            public bool TemPai { get; set; }

            [Required(ErrorMessage = "CPF obrigatório.")]
            //[RegularExpression("([0-9]+)" + "." + "-", ErrorMessage = "CPF somente aceita valores numéricos.")]
            [StringLength(14, MinimumLength = 14, ErrorMessage = "CPF deve ter 11 dígitos.")]
            public string CPF { get; set; }

            [Required (ErrorMessage = "RG obrigatório.")]
            [StringLength(12, MinimumLength = 12, ErrorMessage = "O RG deve ter 9 dígitos.")]
            public string RG { get; set; }

            [Required(ErrorMessage = "Sexo obrigatório.")]
            public int Sexo { get; set; }

            [Required(ErrorMessage = "CEP obrigatório.")]
            //[StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos.")]
            public string CEP { get; set; }

            [Required(ErrorMessage = "A Rua é obrigatório.")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres.")]
            public string Rua { get; set; }

            [Required(ErrorMessage = "Complemento é obrigatório.")]
            [StringLength(100, ErrorMessage = "Complemento deve ter no máximo 100 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatória.")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado é obrigatório.")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Número do telefone é obrigatório.")]

            //[StringLength(12, MinimumLength = 12, ErrorMessage = "CEP deve ter 8 dígitos.")]
            public string Telefone1 { get; set; }

            //[RegularExpression("([0-9]+)", ErrorMessage = "Número do telefone somente aceita valores numéricos.")]
            public string Telefone2 { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda é obrigatória.")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda deve ser um valor positivo.")]
            public Double Renda { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }
        }
    }
}
