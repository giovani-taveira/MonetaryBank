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
            //............Frm_Cadastro.................
            //Dados Pessoais
            [Required(ErrorMessage = "Nome é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome  deve ter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai deve ter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            [StringLength(50, ErrorMessage = "Nome da Mãe deve ter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }

            public bool TemMae { get; set; }
            public bool TemPai { get; set; }

            //[Required(ErrorMessage = "CPF obrigatório.")]
            [StringLength(14, MinimumLength = 14, ErrorMessage = "CPF deve ter 11 dígitos.")]
            public string CPF { get; set; }

            [Required (ErrorMessage = "RG obrigatório.")]
            [StringLength(12, MinimumLength = 12, ErrorMessage = "O RG deve ter 9 dígitos.")]
            public string RG { get; set; }

            [Required(ErrorMessage = "A Data de Nascimento é obrigatória.")]
            [StringLength(10, MinimumLength = 10, ErrorMessage = "A Data de nascimento deve ter 8 dígitos")]
            public string DataDeNascimento { get; set; }

            [Required(ErrorMessage = "Sexo obrigatório.")]
            public int Sexo { get; set; }

            [Required(ErrorMessage = "Número do telefone é obrigatório.")]
            [StringLength(14, MinimumLength = 14, ErrorMessage = "O telefone deve ter 9 dígitos.")]
            public string Telefone1 { get; set; }


            //Endereço
            [Required(ErrorMessage = "CEP obrigatório.")]
            [StringLength(9, MinimumLength = 9, ErrorMessage = "O CEP deve ter 8 dígitos.")]
            public string CEP { get; set; }

            [Required(ErrorMessage = "A Rua é obrigatório.")]
            [StringLength(100, ErrorMessage = "A Rua deve ter no máximo 100 caracteres.")]
            public string Rua { get; set; }

            [Required(ErrorMessage = "O número é obrigatório.")]
            [StringLength(10, ErrorMessage = "O número deve ter no máximo 10 caracteres.")]
            public string Numero { get; set; }

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
            public string Estado { get; set; }


            //Profissão

            [Required(ErrorMessage = "Profissão é obrigatório")]
            [StringLength(100, ErrorMessage = "Profissão deve ter no máximo 100 caracteres.")]
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

        public class Transferencia
        {
            [StringLength(14, MinimumLength = 14, ErrorMessage = "CPF deve ter 11 dígitos.")]
            public string CPFRecebedor { get; set; }
            [Required(ErrorMessage = "O Valor é Obrigatório")]
            public string Valor { get; set; }

            [Required(ErrorMessage = "A Senha é Obrigatória")]
            public string Senha { get; set; }


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

        public class OutrasOperacoes
        {
            [Required(ErrorMessage = "O Valor é Obrigatório")]
            public string Valor { get; set; }

            [Required(ErrorMessage = "A Senha é Obrigatória")]
            public string Senha { get; set; }
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
