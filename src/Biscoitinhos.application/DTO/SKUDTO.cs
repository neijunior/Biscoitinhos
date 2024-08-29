using System.ComponentModel.DataAnnotations;

namespace Biscoitinhos.application.DTO
{
    public class SKUDTO : BaseDTO
    {
        [Required(ErrorMessage = "O SKU é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A Unidade de Medida é obrigatória")]
        public string UnidadeMedida { get; set; }
    }
}
