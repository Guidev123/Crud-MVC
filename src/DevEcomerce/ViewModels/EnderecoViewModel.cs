using DevEcomerce.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DevEcomerce.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        //[Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1] caracteres", MinimumLength = 2)]
        [Required(ErrorMessage="O campo {0} é obrigatório")]
        //[StringLength(200, ErrorMessage ="O campo {0 precisa ter entre {2} e {1} caracteres", MinimumLength =2)]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1] caracteres", MinimumLength = 2)]
        public string Numero { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1] caracteres", MinimumLength = 2)]
        public string Complemento { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[StringLength(8, ErrorMessage = "O campo {0} precisa ter entre {2} e {1] caracteres", MinimumLength = 2)]
        [StringLength(8, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength =2)]
        public string Cep { get; set; }
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        //[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1] caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1] caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1] caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        [HiddenInput] //Será criado com hidden no formulário ao invés de texto
        public Guid FornecedorId { get; set; }
    }
}
