using DevEcomerce.Business.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevEcomerce.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caractres", MinimumLength = 2)]
        public string Nome { get; set; }



        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(200,ErrorMessage ="O campo {0} deve ter entre {2} e {1} caractres", MinimumLength =2)]
        public string Documento { get; set; }

        [DisplayName("Tipo")]
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public int TipoFornecedor { get; set; }
        public EnderecoViewModel? Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel>? Produtos { get; set; }
    }
}
